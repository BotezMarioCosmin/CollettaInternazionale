using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CollettaDizionario
{
    public partial class Form1 : Form
    {
        Dictionary<string, float> colletta = new Dictionary<string, float>();
        string[] valute = new string[] { "€", "$", "£"};
        float totale = 0;
        float totaleDaVersare = 0;
        public Form1()
        {
            InitializeComponent();
            listView1.Clear();
            listView1.Columns.Add("Nome");
            listView1.Columns.Add("Importo");

            for (int i = 0; i < valute.Length; i++)
            {
                comboBox1.Items.Add(valute[i]);
            }
            /*
            Dictionary<Persona,Importo> tabella=new Dictionary<Persona,Importo>(); 

            Object o1=new Persona("P01","Rossi","Mario");
            Object o2=new Persona("P02","Bianchi","Mario");
            Object o3=new Persona("P01","Rossi","Mariolino");

            Persona p1=new Persona("P01","Rossi","Mario");
            Persona p2=new Persona("P02","Bianchi","Mario");
            Persona p3=new Persona("P01","Rossi","Mariolino");

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));

            Console.WriteLine(o1.Equals(o2));
            Console.WriteLine(o1.Equals(o3));

            Importo i1=new Importo(50, "euro");
            Importo i2=new Importo(500, "euro");

            tabella[p1]=i1;

            Console.WriteLine(tabella[p1]);

            tabella[p3]=i2;

            Console.WriteLine(tabella[p1]);
            Console.WriteLine(tabella[p3]);
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTotale_Click(object sender, EventArgs e)
        {
            totale = float.Parse(textBoxTotale.Text);
            labelTotal.Text = "Totale: " + textBoxTotale.Text;
            textBoxTotale.Text = null;
        }

        private void textBoxAggiungiNome_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = null;
        }

        private void textBoxAggiungiImporto_Click(object sender, EventArgs e)
        {
            textBoxImporto.Text = null;
        }

        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "Nome" || textBoxNome.Text != null || textBoxImporto.Text != "Importo" || textBoxImporto.Text != null)
            {
                try
                {
                    colletta.Add(textBoxNome.Text, float.Parse(textBoxImporto.Text));
                    string[] row = { textBoxNome.Text, textBoxImporto.Text };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    listViewRefresh(colletta);
                }
                catch
                {
                    MessageBox.Show("Valori non validi!");
                }
            }
            textBoxNome.Text = "Nome";
            textBoxImporto.Text = "Importo";

        }

        private void buttonCancella_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "Nome" || textBoxNome.Text != null)
            {
                try
                {
                    colletta.Remove(textBoxNome.Text);
                    listViewRefresh(colletta);
                    refreshTotal(colletta);
                }
                catch
                {
                    MessageBox.Show("Persone inesistente!");
                }
            }
            textBoxNome.Text = "Nome";
            textBoxImporto.Text = "Importo";
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text != "Nome" || textBoxNome.Text != null || textBoxImporto.Text != "Importo" || textBoxImporto.Text != null)
            {
                try
                {
                    string nome = textBoxNome.Text;
                    colletta.Remove(nome);
                    colletta.Add(textBoxNome.Text, float.Parse(textBoxImporto.Text));
                    string[] row = { textBoxNome.Text, textBoxImporto.Text };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    listViewRefresh(colletta);
                }
                catch
                {
                    MessageBox.Show("Persona inesistente.");
                }
            }
            else
            {
                MessageBox.Show("Inserire il nome e il nuovo importo.");
            }
        }

        public void listViewRefresh(Dictionary<string, float> dict)
        {
            listView1.Clear();
            listView1.Columns.Add("Nome");
            listView1.Columns.Add("Importo");

            foreach (KeyValuePair<string, float> kvp in dict)
            {
                ListViewItem item = new ListViewItem(kvp.Key);
                item.SubItems.Add(kvp.Value.ToString());
                listView1.Items.Add(item);
            }
            refreshTotal(colletta);
        }

        public void refreshTotal(Dictionary<string, float> dict)
        {
            totaleDaVersare = 0;
            foreach (KeyValuePair<string, float> kvp in dict)
            {
                totaleDaVersare += kvp.Value;
            }
            labelTotaleVersato.Text = "Totale versato: " + totaleDaVersare;
        }

        private void buttonOrdinaNome_Click(object sender, EventArgs e)
        {
            OrdinaNome(colletta);
            listViewRefresh(colletta);
        }
        private void buttonOrdinaImporto_Click(object sender, EventArgs e)
        {
            OrdinaImporto(colletta);
            listViewRefresh(colletta);
        }

        public Dictionary<string, float> OrdinaNome(Dictionary<string, float> dizionarioDaOrdinare)
        {
            var dizionarioOrdinato = dizionarioDaOrdinare.OrderBy(x => x.Key);

            var nuovoDizionario = new Dictionary<string, float>();

            foreach (var elemento in dizionarioOrdinato)
            {
                nuovoDizionario.Add(elemento.Key, elemento.Value);
            }

            return nuovoDizionario;
        }


        public Dictionary<string, float> OrdinaImporto(Dictionary<string, float> dizionarioDaOrdinare)
        {
            var dizionarioOrdinato = dizionarioDaOrdinare.OrderBy(x => x.Value);

            var nuovoDizionario = new Dictionary<string, float>();

            foreach (var elemento in dizionarioOrdinato)
            {
                nuovoDizionario.Add(elemento.Key, elemento.Value);
            }

            return nuovoDizionario;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            MessageBox.Show("Hai selezionato la valuta: " +a);
        }
    }
}