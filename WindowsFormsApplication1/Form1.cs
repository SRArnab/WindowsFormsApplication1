using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        databasecontrol db = new databasecontrol();
        
        public Form1()
        {
            
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MySqlConnection con = db.DBconnection();
            string query1 = "select * from equipments";
            MySqlCommand cmd1 = new MySqlCommand(query1,con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            inventoryDataGridView.DataSource = dt;

            DataTable dt1 = db.getAll();
            equipmentsDataGridview.DataSource= dt1;

            con.Close();
           // inventoryDataGridView.Columns[4].ToString();
            

           // inventoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill;

            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            buttonAndPanelEnable(homePanel, ItemAddingPanel, equipmentPanel, checkListPanel, additemPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            buttonAndPanelEnable(equipmentPanel,homePanel,ItemAddingPanel,checkListPanel,additemPanel);
            Form1_Load(sender,e);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Exit:", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            

           // button4.Size=
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            buttonAndPanelEnable(ItemAddingPanel, homePanel,equipmentPanel,checkListPanel,additemPanel);
        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonAndPanelEnable(Panel vispn, Panel dispn, Panel dispn2, Panel dispn3, Panel dispn4) {
                vispn.Enabled = true;
                vispn.Visible = true;
                dispn.Visible = false;
                dispn.Enabled = false;
                dispn2.Enabled = false;
                dispn2.Visible = false;
                dispn3.Visible = false;
                dispn3.Enabled = false;
                dispn4.Visible = false;
                dispn4.Enabled = false;
            
                

        
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            buttonAndPanelEnable(homePanel,ItemAddingPanel,equipmentPanel,checkListPanel,additemPanel);

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

  

        private void button3_Click(object sender, EventArgs e)
        {
            buttonAndPanelEnable(checkListPanel, ItemAddingPanel, homePanel,equipmentPanel,additemPanel);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void test1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.test1BindingSource.EndEdit();
          

        }

        private void test1BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.test1BindingSource.EndEdit();
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonAndPanelEnable(additemPanel, ItemAddingPanel, homePanel,checkListPanel,equipmentPanel);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textfieldCheck(TextBox textbox){
            if (textbox == textBox3) {
                if (textBox3.Text == "")
                {
                    label10.Visible = true;
                }
                else {
                    label10.Visible = false;
                }
                
            }
            else if (textbox == textBox4) {
                if (textBox4.Text == "")
                {
                    label11.Visible = true;
                }
                else
                {
                    label11.Visible = false;
                }
            }
            else if (textbox == textBox5)
            {
                if (textBox5.Text == "")
                {
                    label12.Visible = true;
                }
                else
                {
                    label12.Visible = false;
                }
            }
            else if (textbox == textBox6)
            {
                if (textBox6.Text == "")
                {
                    label13.Visible = true;
                }
                else
                {
                    label13.Visible = false;
                }
            }
            else if (textbox == textBox7)
            {
                if (textBox7.Text == "")
                {
                    label18.Visible = true;
                }
                else
                {
                    label18.Visible = false;
                }
            }
            else if (textbox == textBox8)
            {
                if (textBox8.Text == "")
                {
                    label19.Visible = true;
                }
                else
                {
                    label19.Visible = false;
                }
            }
        }


        private void checkDateTime(DateTimePicker dt) {
            if (dt.Text == "")
            {
                label17.Visible = true;
            }
            else {
                label17.Visible = false;
            }
        }
        private void button9_Click_2(object sender, EventArgs e)
        {

            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text=="" || textBox8.Text=="" || dateTimePicker1.Text=="")
            {
                textfieldCheck(textBox3);
                textfieldCheck(textBox4);
                textfieldCheck(textBox5);
                textfieldCheck(textBox6);
                textfieldCheck(textBox7);
                textfieldCheck(textBox8);
                checkDateTime(dateTimePicker1);
            }
            else
            {
               // MySqlConnection result = db.DBconnection();
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                //DateTime dt = new DateTime(dateTimePicker1.Value);
                int result = db.UpdateDamagedNumber(textBox3.Text.ToString(),textBox4.Text.ToString(),Int32.Parse(textBox6.Text));
                if (result > 0)
                {
                    //MessageBox.Show("Damage updated successfully");
                    int results = db.InsertIntoEquipments(textBox3.Text, textBox4.Text, Int32.Parse(textBox5.Text), Int32.Parse(textBox6.Text), dateTimePicker1.Value.Date, textBox7.Text, textBox8.Text);
                    if (results > 0)
                    {
                        MessageBox.Show("Inserted data successfully");
                        //MessageBox.Show(dateTimePicker1.Text);
                        TextBox[] addItemTextbox = new TextBox[7] { textBox3, textBox4, textBox5, textBox6, textBox7, textBox8 ,quantityTextBox};
                        for (int i = 0; i < addItemTextbox.Length; i++)
                        {
                            addItemTextbox[i].Text = "";
                        }
                    }
                    Form1_Load(sender, e);
                }
                else 
                {
                    MessageBox.Show("Error occured to change damaged number of that item..maybe the item is not available in inventory");
                }
                
                
               
            }

        }

        private void inventoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.inventoryDataGridView.Rows[e.RowIndex];
                textBox9.Text = row.Cells[0].Value.ToString();
                textBox10.Text = row.Cells[1].Value.ToString();
                textBox11.Text = row.Cells[2].Value.ToString();
                textBox12.Text = row.Cells[3].Value.ToString();
                textBox13.Text = row.Cells[5].Value.ToString();
                textBox14.Text = row.Cells[6].Value.ToString();
            
            }
        }
        private void emptyTextbox(TextBox[] textboxarray) 
        {
            for (int i = 0; i < textboxarray.Length; i++)
            {
                textboxarray[i].Text = "";
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "")
            {
                MessageBox.Show("You should select an item from the table first");
            }
            else 
            {
                int result = db.UpdateToEquipment(textBox9.Text, textBox10.Text, Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text), textBox13.Text, textBox14.Text);
                if (result > 0)
                {
                    Form1_Load(sender, e);
                    MessageBox.Show("Data updated");
                    TextBox[] textbox = { textBox9, textBox10, textBox11, textBox12, textBox13, textBox14 };
                    emptyTextbox(textbox);
                }
            }
         
            
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            db.EmptyEquipmentsTable();
            MessageBox.Show("All data Cleared");
            Form1_Load(sender,e);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            damagePanel.Visible = true;
            damagePanel.Enabled = true;
            DataTable dt = db.getAll();
            dataGridView2.DataSource = dt;
        }

        private void damagePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            string itemname = textBox3.Text.ToString() ;
            string itemtype = textBox4.Text.ToString();
            int res = db.FindQuantity(itemname,itemtype);
            if (res > 0)
            {
                button9.Enabled = true;
                quantityTextBox.Text = res.ToString();
                int rest = db.FindDamaged(itemname, itemtype);
                remainingText.Text = (res - rest).ToString();


            }
            else 
            {
                MessageBox.Show("Item not found on Inventory");
                button9.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(remainingText.Text) < Int32.Parse(textBox5.Text))
            {
                MessageBox.Show("Out of stock");
                button9.Enabled = false;
            }
            else 
            {
                button9.Enabled = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            damagePanel.Visible = false;
            damagePanel.Enabled = false;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (textBox15.Enabled == false)
            {
                label28.Visible = true;
                textBox15.Visible = true;
                textBox15.Enabled = true;
            }
            else if (textBox15.Enabled == true && textBox15.Text == "") 
            {
                MessageBox.Show("You must have to enter a file name");
            }
            else if (textBox15.Enabled == true && textBox15.Text != "")
            {
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable pdftable = new PdfPTable(dataGridView2.Columns.Count);
                pdftable.DefaultCell.Padding = 3;
                pdftable.WidthPercentage = 100;
                pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdftable.DefaultCell.BorderWidth = 1;
                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

                foreach (DataGridViewColumn column in dataGridView2.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdftable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                    }

                }
                var saveFiledialoge = new SaveFileDialog();
                saveFiledialoge.FileName = textBox15.Text.ToString();
                saveFiledialoge.DefaultExt = ".pdf";
                if (saveFiledialoge.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFiledialoge.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(pdftable);
                        pdfdoc.Close();
                        stream.Close();
                        MessageBox.Show("File created successfully");
                    }
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            DataTable dt = db.searchItemFromTools(searchTextBox.Text.ToString());
            equipmentsDataGridview.DataSource = dt;

        }

        private void label36_Click(object sender, EventArgs e)
        {
            DataTable dt = db.getAll();
            equipmentsDataGridview.DataSource = dt;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "")
            {
                label38.Visible = true;
            }
            else 
            {
                label38.Visible = false;
               int res= db.updateToTools(Int32.Parse(textBox16.Text), textBox17.Text.ToString(), textBox18.Text.ToString(), Int32.Parse(textBox19.Text), Int32.Parse(textBox20.Text));
               if (res > 0)
               {
                   
                   MySqlConnection con = db.DBconnection();
                   string query = "select * from tools where id = '" + Int32.Parse(textBox16.Text) + "'and itemname='" + textBox17.Text.ToString() + "'";
                   MySqlCommand cmd1 = new MySqlCommand(query, con);
                   MySqlDataAdapter da = new MySqlDataAdapter(cmd1);
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   equipmentsDataGridview.DataSource = dt;
               }
              
            }
        }

        private void equipmentsDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Enabled = true;
            panel3.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.equipmentsDataGridview.Rows[e.RowIndex];
                textBox16.Text = row.Cells[0].Value.ToString();
                textBox17.Text = row.Cells[1].Value.ToString();
                textBox18.Text = row.Cells[2].Value.ToString();
                textBox19.Text = row.Cells[3].Value.ToString();
                textBox20.Text = row.Cells[4].Value.ToString();
                

            }
        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" | textBox21.Text == "" || textBox22.Text == "")
            {
                label43.Visible = true;
            }
            else 
            {
                label43.Visible = false;
                int res = db.InsertIntoTools(textBox1.Text.ToString(), textBox2.Text.ToString(), Int32.Parse(textBox21.Text), Int32.Parse(textBox22.Text));
                if (res == 0) 
                {
                    MessageBox.Show("Error...This item is already on the list");
                }
                else if (res == 1) 
                {
                    MessageBox.Show("Item inserted successfully");
                    TextBox[] additemText = { textBox1, textBox2, textBox21, textBox22};
                    emptyTextbox(additemText);

                }
                else if (res == 3) 
                {
                    MessageBox.Show("Error...Item wasn't inserted successfully");
                }
            }
        }

        private void ResistorsButton_Click(object sender, EventArgs e)
        {
            
            equipmentsLabel.Text = "Resistors";
            DataTable dt = db.searchItemFromTools("Resistors");
            shortcutDataGridView.DataSource = dt;
            shortcutPanel.Visible = true;
            shortcutPanel.Enabled = true;
            homePanel.Visible = false;
            homePanel.Enabled = false;
        }

        private void roundButton9_Click(object sender, EventArgs e)
        {
            shortcutPanel.Visible = true;
            shortcutPanel.Enabled = true;
            homePanel.Visible = false;
            homePanel.Enabled = false;
            equipmentsLabel.Text = "Switchs";
            DataTable dt = db.searchItemFromTools("Switchs");
            shortcutDataGridView.DataSource = dt;
        }

        private void roundButton8_Click(object sender, EventArgs e)
        {
            shortcutPanel.Visible = true;
            shortcutPanel.Enabled = true;
            homePanel.Visible = false;
            homePanel.Enabled = false;
            equipmentsLabel.Text = "Bread Boards";
            DataTable dt = db.searchItemFromTools("Bread Boards");
            shortcutDataGridView.DataSource = dt;
        }

        private void roundButton7_Click(object sender, EventArgs e)
        {
            shortcutPanel.Visible = true;
            shortcutPanel.Enabled = true;
            homePanel.Visible = false;
            homePanel.Enabled = false;
            equipmentsLabel.Text = "Jumper Wire";
            DataTable dt = db.searchItemFromTools("Jumper");
            shortcutDataGridView.DataSource = dt;
        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            shortcutPanel.Visible = true;
            shortcutPanel.Enabled = true;
            homePanel.Visible = false;
            homePanel.Enabled = false;
            equipmentsLabel.Text = "7 segment display";
            DataTable dt = db.searchItemFromTools("7 segment-display");
            shortcutDataGridView.DataSource = dt;
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            shortcutPanel.Visible = true;
            shortcutPanel.Enabled = true;
            homePanel.Visible = false;
            homePanel.Enabled = false;
            equipmentsLabel.Text = "Transistors";
            DataTable dt = db.searchItemFromTools("Transistors");
            shortcutDataGridView.DataSource = dt;
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            shortcutPanel.Visible = true;
            shortcutPanel.Enabled = true;
            homePanel.Visible = false;
            homePanel.Enabled = false;
            equipmentsLabel.Text = "Led Lights";
            DataTable dt = db.searchItemFromTools("LED");
            shortcutDataGridView.DataSource = dt;
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            shortcutPanel.Visible = true;
            shortcutPanel.Enabled = true;
            homePanel.Visible = false;
            homePanel.Enabled = false;
            equipmentsLabel.Text = "Diodes";
            DataTable dt = db.searchItemFromTools("Diodes");
            shortcutDataGridView.DataSource = dt;
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            shortcutPanel.Visible = true;
            shortcutPanel.Enabled = true;
            homePanel.Visible = false;
            homePanel.Enabled = false;
            equipmentsLabel.Text = "Capacitors";
            DataTable dt = db.searchItemFromTools("Capacitors");
            shortcutDataGridView.DataSource = dt;
        }

        private void roundButton10_Click(object sender, EventArgs e)
        {
            shortcutPanel.Visible = true;
            shortcutPanel.Enabled = true;
            homePanel.Visible = false;
            homePanel.Enabled = false;
            equipmentsLabel.Text = "Micro-controllers";
            DataTable dt = db.searchItemFromTools("Micro-Controllers");
            shortcutDataGridView.DataSource = dt;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            shortcutPanel.Visible = false;
            shortcutPanel.Enabled = false;
            homePanel.Visible = false;
            homePanel.Enabled = false;
            homePanel.Visible = true;
            homePanel.Enabled = true;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAndPanelEnable(homePanel, ItemAddingPanel, equipmentPanel, checkListPanel, additemPanel);
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAndPanelEnable(ItemAddingPanel, homePanel, equipmentPanel, checkListPanel, additemPanel);
        }

        private void equipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAndPanelEnable(equipmentPanel, homePanel, ItemAddingPanel, checkListPanel, additemPanel);
            Form1_Load(sender, e);
        }

        private void orderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAndPanelEnable(checkListPanel, ItemAddingPanel, homePanel, equipmentPanel, additemPanel);
        }

        private void orderItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonAndPanelEnable(additemPanel, ItemAddingPanel, homePanel, checkListPanel, equipmentPanel);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to Exit:", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
    }
}
