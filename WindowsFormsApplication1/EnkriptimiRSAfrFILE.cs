using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;        //per assambly
using System.Resources;         //per ResourseMenager
using System.Globalization;     //per CultureInfo

using System.Security.Cryptography;
using System.IO;

namespace RSAfFile
{
    public partial class EnkriptimiRSAfrFILE : Form
    {
        
        public EnkriptimiRSAfrFILE()
        {
            InitializeComponent();
            CultureInfo ci = new CultureInfo("al-AL"); //nese pc nuk e ka kete kulture ateher duhet prape en-US
            NdrroGjuhen(ci, "RSAfFile.gjuha.Al-res");
            tstStatusiMomental.Text = filloj;    //statusi fillestar i aplikacionit        
        }
       
        private void btnShfletoCelsin_Click(object sender, EventArgs e)//gjej celsin
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XML Files (*.xml)|*.xml";
            open.FilterIndex = 0;
            open.DefaultExt = "xml";

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtShtegCelsi.Text = open.FileName;
            tstStatusiMomental.Text = filloj;
        } 

        private void btnShfleto_Click(object sender, EventArgs e)//gjej fajllin
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtShtegu.Text = open.FileName;            
        }

        private void btnEnkripto_Click(object sender, EventArgs e)
        {
            if (progresi.Value == 100) progresi.Value = 0;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            if (txtShtegCelsi.Text != "")
            {
                StreamReader sr = new StreamReader(txtShtegCelsi.Text); //ose @"C:\Users\CCKS\Desktop\celesi.xml");
                string tekstiLexuar = sr.ReadToEnd(); //lexo deri nfund
                sr.Close();//mbylle sr leximin                
                rsa.FromXmlString(tekstiLexuar);
            }
            else MessageBox.Show("Zgjidhni celsin per enkriptim");


            byte[] bitPlain = System.IO.File.ReadAllBytes(txtShtegu.Text);//plainteksti lexohet b per b ne path
            try
            {
                byte[] bitEncrypt = rsa.Encrypt(bitPlain, true);//tr per paddingun OAEP qe bene per Windows xp +, perndryshe false per padd. PKCS
                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllBytes(save.FileName, bitEncrypt);
                    tstStatusiMomental.Text = perfundoi;  //shfaqet stringu me tregu ne status qe puna perfundoi
                }              
            }
            catch (Exception gabim)
            {
                MessageBox.Show("Ka ndodhe nje gabim \n\n" + gabim.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            progresi.Value = 100;
        }

        private void Dekripto_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            if (txtShtegCelsi.Text != "")
            {
                StreamReader sr = new StreamReader(txtShtegCelsi.Text); //ose @"C:\Users\CCKS\Desktop\celesi.xml");
                string tekstiLexuar = sr.ReadToEnd();
                sr.Close();
                rsa.FromXmlString(tekstiLexuar);
            }
            else MessageBox.Show("Zgjidhni celsin per dekriptim");
            byte[] bitCipher = System.IO.File.ReadAllBytes(txtShtegu.Text);
            try
            {
                byte[] bitDecrypt = rsa.Decrypt(bitCipher, true);

                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllBytes(save.FileName, bitDecrypt);
                    tstStatusiMomental.Text = perfundoi;  //shfaqet stringu me tregu ne status qe puna perfundoi
                }
            }
            catch (Exception gabim)
            {
                MessageBox.Show("Ka ndodhe nje gabim \n\n"+gabim.Message,"Gabim",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }      

        private void tmrOra_Tick(object sender, EventArgs e)//ORA aktuale 
        {
            tstora.Text = DateTime.Now.ToString("HH:mm:ss ");
        }

        private void mnuGjuha_Shqip_Click(object sender, EventArgs e)//nderrim te gjuhes ne SHQIP
        {
            CultureInfo ci = new CultureInfo("al-AL"); //nese pc nuk e ka kete kulture ateher duhet prape en-US
            NdrroGjuhen(ci, "RSAfFile.gjuha.Al-res");
            mnuGjuha_Shqip.Image = RSAfFile.Properties.Resources.Shqip;  //ndrron edhe foton ne shqip
            mnuGjuha_Anglisht.Image = null;    //ndersa anglisht e hjek foton
        }

        private void mnuGjuha_Anglisht_Click(object sender, EventArgs e)//nderrim te gjuhes ne Anglisht
        {
            CultureInfo ci = new CultureInfo("en-US");
            NdrroGjuhen(ci, "RSAfFile.gjuha.En-res");
            mnuGjuha_Anglisht.Image = RSAfFile.Properties.Resources.English;
            mnuGjuha_Shqip.Image = null;
        }
        
        string ndihm = "", ndihmEmri = "", info="", infoemri="", perfundoi="", filloj=""; 
        private void NdrroGjuhen(CultureInfo ci, string q)  //funksioni qe ndrron gjuhen
        {
            Assembly a = Assembly.Load("WindowsFormsApplication1");
            ResourceManager rm = new ResourceManager(q, a);

            menOpsione.Text = rm.GetString("Opsione", ci);
            menOpsione_Mbyll.Text = rm.GetString("Mbyll", ci);
            mnuGjuha.Text = rm.GetString("Gjuha", ci);
            mnuGjuha_Shqip.Text = rm.GetString("Shqip", ci);
            mnuGjuha_Anglisht.Text = rm.GetString("Anglisht", ci);
            mnuNdihma.Text = rm.GetString("Ndihma", ci);
            mnuNdihma_RrethNesh.Text = rm.GetString("RrethNesh", ci);
            lblShtegu.Text = rm.GetString("shteguifilet", ci);
            btnShfleto.Text = rm.GetString("Shfleto", ci);
            btnEnkripto.Text = rm.GetString("Enkripto", ci);
            btnDekripto.Text = rm.GetString("Dekripto", ci);
            tstStatusi.Text = rm.GetString("Statusi", ci);            
            tstKohaaktuale.Text = rm.GetString("Kohaaktual", ci);
            btnShfletoCelsin.Text = rm.GetString("Shfleto", ci);
            lblCelsi.Text = rm.GetString("shtegucelsit", ci);

            ndihm = rm.GetString("ndihm", ci);
            ndihmEmri = rm.GetString("ndihmEmri", ci);
            info = rm.GetString("info", ci);
            infoemri = rm.GetString("infoemri", ci);
            filloj= rm.GetString("Nepritje", ci);
            perfundoi = rm.GetString("perfundoi", ci);  
            this.Text = rm.GetString("titulli", ci);
        }

        private void menOpsione_Mbyll_Click(object sender, EventArgs e)//vegla mbyllese
        {
            Close();
        }

        private void mnuNdihma_Info_Click(object sender, EventArgs e)//vegla info
        {
            MessageBox.Show(ndihm, ndihmEmri, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuNdihma_RrethNesh_Click(object sender, EventArgs e)//vegla rreth nesh
        {
            MessageBox.Show(info, infoemri, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       

       

    }
}
