namespace WordPad_Killer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FontBox1.DataSource = FontFamily.Families;
            FontBox1.DisplayMember= "Name";
            FontBox1.SelectedItem = FontFamily.Families.Cast<FontFamily>().FirstOrDefault(f => f.Name == "Arial");
            string[] sizes = { "2", "4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" };
            foreach (var size in sizes)
            {
                SizeBox1.Items.Add(size);
            }
            SizeBox1.SelectedItem = "12";
        }

        private void SizeBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FontBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }
    }
}