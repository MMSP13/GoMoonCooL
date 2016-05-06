using AutoBase.Model;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBase
{
    public partial class MainForm : Form
    {
        const int cAktsii = 3;
        const int cEmitent = 3;

        private Configuration myConfig;
        private ISessionFactory mySessionFactory;
        private ISession mySession;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            mySessionFactory = DBService.Factory;
            mySession = mySessionFactory.OpenSession();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mySession.Close();
        }
        private void Add(Entity Object)
        {
            using (mySession.BeginTransaction())
            {
                mySession.Save(Object);
                mySession.Transaction.Commit();
                mySession.Flush();
            }
        }
        private void btnCarList_Click(object sender, EventArgs e)
        {
            try
            {
                using (mySession.BeginTransaction())
                {
                    ICriteria myCriteria = mySession.CreateCriteria<Emitent>();
                    IList<Emitent> list = myCriteria.List<Emitent>();
                    mySession.Transaction.Commit();
                    mySession.Flush();
                    dgvData.ColumnCount = cEmitent;
                    int n = list.Count;
                    dgvData.RowCount = n;
                    dgvData.Columns[0].Name = "Имя";
                    dgvData.Columns[1].Name = "Представитель";
                    dgvData.Columns[2].Name = "Адрес";
                    dgvData.AutoResizeColumnHeadersHeight();
                    dgvData.AutoResizeColumns();
                    for (int i = 0; i < n; i++)
                    {
                        dgvData[0, i].Value = list[i].Name;
                        dgvData[1, i].Value = list[i].Person;
                        dgvData[2, i].Value = list[i].Address;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListEngine_Click(object sender, EventArgs e)
        {
            try
            {
                using (mySession.BeginTransaction())
                {
                    ICriteria myCriteria = mySession.CreateCriteria<Aktsii>();
                    IList<Aktsii> list = myCriteria.List<Aktsii>();
                    mySession.Transaction.Commit();
                    mySession.Flush();
                    dgvData.ColumnCount = cAktsii;
                    int n = list.Count;
                    dgvData.RowCount = n;
                    dgvData.Columns[0].Name = "Название";
                    dgvData.Columns[1].Name = "Стоимость";
                    dgvData.Columns[2].Name = "Количество";
                    dgvData.AutoResizeColumnHeadersHeight();
                    dgvData.AutoResizeColumns();
                    for (int i=0; i < n; i++)
                    {
                        dgvData[0, i].Value = list[i].Name;
                        dgvData[1, i].Value = list[i].Cost;
                        dgvData[2, i].Value = list[i].Count;
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            /*try
            {
                AutoBase.Model.Aktsii SendingEngine = new AutoBase.Model.Aktsii { Id = 3, Name = "ufpghjv", Cost = "100", Count = "225"};
                AutoBase.Model.Emitent SendingCar = new AutoBase.Model.Emitent { Name = "ooo", Person = "Vasia", Address = "Perm", aktsii_id = SendingEngine };
                Add(SendingCar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AutoBase.Model.Aktsii SendingEngine = new AutoBase.Model.Aktsii { Id = 1, Name = "Лукойл", Cost = "100", Count = "225"};
                AutoBase.Model.Emitent SendingCar = new AutoBase.Model.Emitent { Name = "ООО Лукойл", Person = "Vasia", Address = "Perm", Aktsii_id = SendingEngine };
                Add(SendingCar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
