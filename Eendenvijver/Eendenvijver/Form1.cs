namespace Eendenvijver
{
    public partial class Form1 : Form
    {
        private int selectedEend;
        Vijver vijver = new Vijver();

        public Form1()
        {
            InitializeComponent();

            UpdateListbox(); //Eenden worden hier een random geslacht geveven
        }

        private void ComboBoxSelectedEend_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEend = ComboBoxSelectedEend.SelectedIndex;
        }

        private void ButtonMaakEend_Click(object sender, EventArgs e)
        {
            if (ComboBoxEendGeslacht.SelectedIndex != -1)
            {
                Geslacht geslacht = (Geslacht)Enum.Parse(typeof(Geslacht), ComboBoxEendGeslacht.SelectedItem.ToString());
                vijver.ChangeGeslacht(selectedEend, geslacht);
            }
            UpdateListbox(); //update de listbox met de veranderde eend
        }

        private void UpdateListbox ()
        {
            ListBoxGemaakteEenden.Items.Clear(); //clear zodat er niet meer dan 6 waarden in de listbox staan
            foreach (Eend eend in vijver.GetEend())
            {
                ListBoxGemaakteEenden.Items.Add(eend.GetGeslacht().ToString());
            }
        }
    }
}