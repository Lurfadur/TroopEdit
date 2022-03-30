using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using TroopEdit.Models.Troops;

namespace TroopEdit
{
    public partial class TroopPublisher : Form
    {
        private string jsonPath;
        private Troops troopsFromJson;
        private Troop currentTroop;

        public TroopPublisher()
        {
            InitializeComponent();
        }

        private void LoadJsonButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Json Files (*.json*)|*.json*",
                FilterIndex = 1,
                Multiselect = false
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                jsonPath = openFile.FileName;
                LoadJsonFile();
            } 
        }

        private void LoadJsonFile()
        {
            string text = File.ReadAllText(jsonPath);
            troopsFromJson = JsonConvert.DeserializeObject<Troops>(text);
            AddTroopButton.Enabled = true;

            UpdateTreeView();
        }

        private void UpdateTreeView()
        {
            TroopTreeView.Nodes.Clear();

            for (int i = 0; i < troopsFromJson.troops.Count; i++)
            {
                Troop troop = troopsFromJson.troops[i];
                TroopTreeView.Nodes.Add(troop.Name);

                if (troop.DerivedTroops != null && troop.DerivedTroops.Count > 0)
                {
                    for (int j = 0; j < troop.DerivedTroops.Count; j++)
                    {
                        TroopTreeView.Nodes[i].Nodes.Add(troop.DerivedTroops[j].Name);
                    }
                }
            }

            SaveJsonFile.Enabled = true;
            ExportToBinaryButton.Enabled = true;
        }

        private void SaveJsonFile_Click(object sender, EventArgs e)
        {
            string updateJsonString = JsonConvert.SerializeObject(troopsFromJson);
            try
            {
                File.WriteAllText(jsonPath, updateJsonString);
            } 
            catch (Exception ex)
            {
                DisplayErrorMessage("Could not update JSON File. Error: " + ex.Message, "JSON File Save Error");
                return;
            }

            MessageBox.Show("Updated JSON file at " + jsonPath, "Update JSON Complete",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadJsonFile();
        }

        private void ExportToBinaryButton_Click(object sender, EventArgs e)
        {
            //create binary file
            uint length = (uint)troopsFromJson.troops.Count;

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Binary File|*.bin*",
                Title = "Save as Binary File",
                DefaultExt = "bin"
            };
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                using(Stream s = saveFileDialog.OpenFile())
                {
                    var bw = new BinaryWriter(s);

                    //create header info
                    bw.Write(Encoding.UTF8.GetBytes("TROP"));
                    bw.Write(Encoding.UTF8.GetBytes("01"));

                    byte[] troopNameLength = new byte[4];
                    troopNameLength[0] = (byte)(length >> 24);
                    troopNameLength[1] = (byte)(length >> 16);
                    troopNameLength[2] = (byte)(length >> 8);
                    troopNameLength[3] = (byte)(length);
                    bw.Write(troopNameLength);

                    foreach (Troop troop in troopsFromJson.troops)
                    {
                        WriteTroopToBinary(troop, bw);

                        if (troop.DerivedTroops != null && troop.DerivedTroops.Count > 0)
                        {
                            foreach (Troop dTroop in troop.DerivedTroops)
                            {
                                WriteTroopToBinary(dTroop, bw);
                            }
                        }
                    }
                }

                MessageBox.Show("Created Binary file at " + saveFileDialog.FileName, "Convert to Binary Complete",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TroopTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string currentName = TroopTreeView.SelectedNode.Text;

            RemoveTroopButton.Enabled = true;

            foreach (Troop troop in troopsFromJson.troops)
            {
                if (troop.Name.Equals(currentName))
                {
                    currentTroop = troop;
                    SetSelectedTroopBoxes(troop);
                }

                if (troop.DerivedTroops != null && troop.DerivedTroops.Count > 0)
                {
                    foreach (Troop dTroop in troop.DerivedTroops)
                    {
                        if (dTroop.Name.Equals(currentName))
                        {
                            currentTroop = dTroop;
                            SetSelectedTroopBoxes(dTroop, troop.Name);
                        }
                    }
                }
            }
        }

        private void SetSelectedTroopBoxes(Troop troop, string mainTroop = "")
        {
            SelectedTroopNameBox.Text = troop.Name;
            SelectedTroopDamageBox.Text = troop.Damage.ToString();
            SelectedTroopHealthBox.Text = troop.Health.ToString();
            SelectedTroopTypeComboBox.SelectedItem = troop.Type;
            SelectedTroopTargetComboBox.SelectedItem = troop.Target;

            if (!string.IsNullOrWhiteSpace(mainTroop))
            {
                MainTroopBox.Text = mainTroop;
            }
            else
            {
                MainTroopBox.Clear();
            }
        }

        private void AddTroopButton_Click(object sender, EventArgs e)
        {
            Troop newTroop = new Troop() { Name = SelectedTroopNameBox.Text };

            if (int.TryParse(SelectedTroopDamageBox.Text, out int numDamage))
            {
                newTroop.Damage = numDamage;
            }

            if (int.TryParse(SelectedTroopHealthBox.Text, out int numHealth))
            {
                newTroop.Health = numHealth;
            }

            if (SelectedTroopTypeComboBox.SelectedItem != null)
            {
                newTroop.Type = SelectedTroopTypeComboBox.SelectedItem.ToString().Equals("(none)") ?
                    null : SelectedTroopTypeComboBox.SelectedItem.ToString();
            }
            else
            {
                DisplayErrorMessage("Must select a Troop Type or (none).", "Invalid Troop Type.");
                return;
            }

            if (SelectedTroopTargetComboBox.SelectedItem != null)
            {
                newTroop.Target = SelectedTroopTargetComboBox.SelectedItem.ToString().Equals("(none)") ?
                    null : SelectedTroopTargetComboBox.SelectedItem.ToString();
            }
            else
            {
                DisplayErrorMessage("Must select a Troop Target or (none).", "Invalid Troop Target.");
                return;
            }

            if (!string.IsNullOrWhiteSpace(MainTroopBox.Text))
            {
                // update troopsFromJson troop list first
                for (int i = 0; i < troopsFromJson.troops.Count; i++)
                {
                    if (troopsFromJson.troops[i].Name.Equals(MainTroopBox.Text))
                    {
                        if (troopsFromJson.troops[i].DerivedTroops != null)
                        {
                            troopsFromJson.troops[i].DerivedTroops.Add(newTroop);
                        }
                        else
                        {
                            troopsFromJson.troops[i].DerivedTroops = new List<Troop>() { newTroop };
                        }
                    }
                }

                // update tree view
                for (int i = 0; i < TroopTreeView.Nodes.Count; i++)
                {
                    if (TroopTreeView.Nodes[i].Text.Equals(MainTroopBox.Text))
                    {
                        TroopTreeView.Nodes[i].Nodes.Add(newTroop.Name);
                    }
                }
            }
            else
            {
                string errorMessage;

                if (string.IsNullOrWhiteSpace(newTroop.Name))
                {
                    errorMessage = "Troop Name must be valid.";
                }
                else if (newTroop.Damage == null)
                {
                    errorMessage = "Troop Damage must be a valid number.";
                }
                else if (newTroop.Health == null)
                {
                    errorMessage = "Troop Health must be a valid number.";
                }
                else if (newTroop.Target == null)
                {
                    errorMessage = "Troop Target must be a valid option.";
                }
                else if (newTroop.Type == null)
                {
                    errorMessage = "Troop Type must be a valid option.";
                }
                else
                {
                    // fields are valid, create new Troop
                    troopsFromJson.troops.Add(newTroop);
                    TroopTreeView.Nodes.Add(SelectedTroopNameBox.Text);
                    return;
                }

                DisplayErrorMessage(errorMessage, "Invalid Troop Data");
            }
        }

        private void RemoveTroopButton_Click(object sender, EventArgs e)
        {
            // update troopsFromJson troop list first
            if (!string.IsNullOrWhiteSpace(MainTroopBox.Text))
            {
                foreach(Troop mainTroop in troopsFromJson.troops)
                {
                    if (mainTroop.DerivedTroops != null && mainTroop.DerivedTroops.Count > 0)
                    {
                        foreach (Troop dTroop in mainTroop.DerivedTroops)
                        {
                            if (dTroop == currentTroop)
                            {
                                mainTroop.DerivedTroops.Remove(dTroop);
                            }
                            break;
                        }
                    }
                }

                // update tree view
                for (int i = 0; i < TroopTreeView.Nodes.Count; i++)
                {
                    if (TroopTreeView.Nodes[i].Nodes != null && TroopTreeView.Nodes[i].Nodes.Count > 0)
                    {
                        for (int j = 0; j < TroopTreeView.Nodes[i].Nodes.Count; j++)
                        {
                            if (TroopTreeView.Nodes[i].Nodes[j].Text.Equals(currentTroop.Name))
                            {
                                TroopTreeView.Nodes[i].Nodes.RemoveAt(j);
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                troopsFromJson.troops.Remove(currentTroop);

                for (int i = 0; i < TroopTreeView.Nodes.Count; i++)
                {
                    if (TroopTreeView.Nodes[i].Text.Equals(currentTroop.Name))
                    {
                        TroopTreeView.Nodes.RemoveAt(i);
                        return;
                    }
                }
            }
        }

        private void WriteTroopToBinary(Troop troop, BinaryWriter bw)
        {
            // length of troop name in 16-bit
            byte[] troopName = new byte[2];
            troopName[0] = (byte)(troop.Name.Length >> 8);
            troopName[1] = (byte)(troop.Name.Length);
            bw.Write(troopName);

            // utf-8 troop name
            bw.Write(Encoding.UTF8.GetBytes(troop.Name));

            // damage as 16-bit
            byte[] troopDamage = new byte[2];

            if (troop.Damage != null)
            {
                troopDamage[0] = (byte)(troop.Damage >> 8);
                troopDamage[1] = (byte)(troop.Damage);
            }

            bw.Write(troopDamage);

            // health as 32-bit
            byte[] troopHealth = new byte[4];

            if (troop.Health != null)
            {
                troopHealth[0] = (byte)(troop.Health >> 24);
                troopHealth[1] = (byte)(troop.Health >> 16);
                troopHealth[2] = (byte)(troop.Health >> 8);
                troopHealth[3] = (byte)(troop.Health);
            }

            bw.Write(troopHealth);

            /* Troop type and target flags:
                bit 0: type = ground
                bit 1: type = air
                bit 2: target = ground
                bit 3: target = air
                bits 4-7: currently unused
            */
            byte typeAndTarget = 0;

            if (troop.Type.Equals("ground"))
            {
                typeAndTarget ^= (1 << 0);
            }
            else if (troop.Type.Equals("air"))
            {
                typeAndTarget ^= (1 << 1);
            }

            if (troop.Target.Equals("ground"))
            {
                typeAndTarget ^= (1 << 2);
            }
            else if (troop.Target.Equals("air"))
            {
                typeAndTarget ^= (1 << 3);
            }
            else if (troop.Target.Equals("all"))
            {
                typeAndTarget ^= (1 << 2);
                typeAndTarget ^= (1 << 3);
            }

            bw.Write(typeAndTarget);
        }

        private void DisplayErrorMessage(string message, string title)
        {
            MessageBox.Show(message, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateTroopButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < troopsFromJson.troops.Count; i++)
            {
                if (troopsFromJson.troops[i].Name.Equals(currentTroop.Name))
                {
                    UpdateTroopJson(i);
                }
                else if (troopsFromJson.troops[i].DerivedTroops != null &&
                    troopsFromJson.troops[i].DerivedTroops.Count > 0)
                {
                    for (int j = 0; j < troopsFromJson.troops[i].DerivedTroops.Count; j++)
                    {
                        if (troopsFromJson.troops[i].DerivedTroops[j].Name.Equals(currentTroop.Name))
                        {
                            // found it
                            UpdateTroopJson(j, i);
                        }

                    }
                }
            }


        }

        private void UpdateTroopJson(int index, int mainIndex = -1)
        {

            if (mainIndex == -1)
            {
                troopsFromJson.troops[index].Name = SelectedTroopNameBox.Text;
                troopsFromJson.troops[index].Damage = int.Parse(SelectedTroopDamageBox.Text);
                troopsFromJson.troops[index].Health = int.Parse(SelectedTroopHealthBox.Text);
                troopsFromJson.troops[index].Type = SelectedTroopTypeComboBox.SelectedItem.ToString();
                troopsFromJson.troops[index].Target = SelectedTroopTargetComboBox.SelectedItem.ToString();
            }
            else
            {
                troopsFromJson.troops[mainIndex].DerivedTroops[index].Name = SelectedTroopNameBox.Text;
                troopsFromJson.troops[mainIndex].DerivedTroops[index].Type = SelectedTroopTypeComboBox.SelectedItem.ToString();
                troopsFromJson.troops[mainIndex].DerivedTroops[index].Target = SelectedTroopTargetComboBox.SelectedItem.ToString();

                if (int.TryParse(SelectedTroopDamageBox.Text, out int damage))
                {
                    troopsFromJson.troops[mainIndex].DerivedTroops[index].Damage = damage;
                }
                else
                {
                    troopsFromJson.troops[mainIndex].DerivedTroops[index].Damage = null;
                }

                if (int.TryParse(SelectedTroopHealthBox.Text, out int health))
                {
                    troopsFromJson.troops[mainIndex].DerivedTroops[index].Health = health;
                }
                else
                {
                    troopsFromJson.troops[mainIndex].DerivedTroops[index].Health = null;
                }

                if (!MainTroopBox.Text.Equals(troopsFromJson.troops[mainIndex].Name))
                {
                    bool foundMatch = false;

                    for (int i = 0; i < troopsFromJson.troops.Count; i++)
                    {
                        if (troopsFromJson.troops[i].Name.Equals(MainTroopBox.Text))
                        {
                            foundMatch = true;
                            troopsFromJson.troops[i].DerivedTroops.Add(troopsFromJson.troops[mainIndex].DerivedTroops[index]);
                            troopsFromJson.troops[mainIndex].DerivedTroops.RemoveAt(index);
                        }
                    }

                    if (!foundMatch)
                    {
                        DisplayErrorMessage("Can't move troop to other derived troop list", "Derived Troop Transfer Error.");
                    }
                }
            }

            UpdateTreeView();

        }
    }
}
