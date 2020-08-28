using System;
using System.Data;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;


namespace Gestão_Boletos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [STAThread]
        private void Form1_Load(object sender, EventArgs e)        
        {
         
                               


        }

       

           

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        private void btCarregar_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.RootFolder =  Environment.SpecialFolder.MyComputer;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;
                
                string[] allfiles = Directory.GetFiles(folderPath, "*.pdf", SearchOption.AllDirectories);

                dgDados.Rows.Clear();

                foreach (var file in allfiles)
                {
                    FileInfo info = new FileInfo(file);


                    using (var reader = new PdfReader(file))
                    {

                        var parser = new PdfReaderContentParser(reader);

                        var strategy = parser.ProcessContent(1, new LocationTextExtractionStrategyWithPosition());

                        var res = strategy.GetLocations();

                        reader.Close();

                        var searchResult = res.Where(p => p.Text.Contains("Nosso Número")).OrderBy(p => p.Y).Reverse().ToList();

                        
                        var chave = res[9].Text;
                        var numero = "";
                        var data_vencimento_aux = "";
                        string[] numero_aux;
                        var nome = "";
                        string[] numero_separado;
                        string numero_barra="";
                        string[] numero_hifen;
                        string numero_final = "";
                        string[] data_vencimento;
                        string[] data_vencimento_separa;

                        if (chave == "Autenticação Mecânica")
                        {                            
                            numero = res[10].Text;                                                      

                            nome = System.IO.Path.GetFileNameWithoutExtension(file);

                            numero_aux = numero.Split(' ');                          

                            numero_separado = numero_aux[1].Split('/');

                            numero_barra = numero_separado[1] + '/' + numero_separado[2];

                            numero_hifen = numero_barra.Split('-');

                            numero_final = numero_hifen[0] + numero_hifen[1];                                                     

                            data_vencimento_aux = res[6].Text;

                            data_vencimento_separa = data_vencimento_aux.Split(' ');                          

                            data_vencimento = data_vencimento_separa;

                            dgDados.Rows.Add(nome, numero_final, data_vencimento[0]);

                        }
                        else
                        {
                            numero = res[9].Text;

                            data_vencimento_aux = res[4].Text;
                            nome = System.IO.Path.GetFileNameWithoutExtension(file);

                            numero_aux = numero.Split(' ');

                            numero_separado = numero_aux[5].Split('/');

                            numero_barra = numero_separado[1] + '/' + numero_separado[2];

                            numero_hifen = numero_barra.Split('-');

                            numero_final = numero_hifen[0] + numero_hifen[1];

                            data_vencimento = data_vencimento_aux.Split(' ');

                            dgDados.Rows.Add(nome, numero_final, data_vencimento[4]);
                        }

                                         
                    }
                }
            }
        }

        private void btcopiarnome_Click(object sender, EventArgs e)
        {
            if (this.dgDados.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                try                {
                    
                    Clipboard.SetDataObject(
                        this.dgDados.GetClipboardContent());
                   
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                  
                }
            }
        }

        private void dgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
