namespace Eendenvijver
{
    public partial class Form1 : Form
    {
        Ooievaar ooievaar1 = new Ooievaar();
        Vijver vijver = new Vijver();
        Kikker kikker = new Kikker();
        private int selectedEend;
        private int i = 0;
        public Form1()
        {
            InitializeComponent();

            UpdateGeslacht(); //Eenden worden hier een random geslacht geveven
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
            UpdateGeslacht(); //update de listbox met de veranderde eend
        }

        private void UpdateGeslacht()
        {
            ListBoxGemaakteEenden.Items.Clear(); //clear zodat er niet meer dan 6 waarden in de listbox staan
            foreach (Eend eend in vijver.GetEend())
            {
                ListBoxGemaakteEenden.Items.Add(eend.GetGeslacht());
            }
            
            ListBoxGemaakteKikkers.Items.Clear();
            foreach (Kikker kikker in vijver.GetKikkers())
            {
                ListBoxGemaakteKikkers.Items.Add(kikker.GetGeslacht());
                GegetenKikker(kikker.GetGeslacht(), i);
                i++;
            }
            
            foreach (Ooievaar ooievaar in vijver.GetOoievaar())
            {
                TextBoxGeslachtOoievaar.Text = ooievaar.GetGeslacht().ToString();
            }
        }

        private void GegetenKikker(Geslacht geslachtKikker, int kikkernummer)
        {
            kikker = new Kikker(geslachtKikker, kikkernummer);
            this.ooievaar1.GegetenKikker(kikker);
        }

        private void ButtonEetKikker_Click(object sender, EventArgs e)
        {
            ListBoxGegetenKikkers.Items.Clear();
            foreach (Kikker Kikker in this.ooievaar1.Kikkers.ToArray())
            {
                this.ListBoxGegetenKikkers.Items.Add(Kikker.kikkernummer);
            }
        }
    }
}