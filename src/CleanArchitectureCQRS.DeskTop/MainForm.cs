using DevExpress.XtraBars;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace CleanArchitectureCQRS.DeskTop
{
    public partial class MainForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private static readonly HttpClient client = new HttpClient();
        public MainForm()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://localhost:44381/");
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {

        }

        private async Task SetRedis()
        {
            HttpContent content = new StringContent(string.Empty);
            HttpResponseMessage response = await client.PostAsync($"Redis/{txtChave.Text}/{txtValor.Text}", content);
            string resultado = await response.Content.ReadAsStringAsync();
            MessageBox.Show(resultado);
        }

        private async Task GetRedis()
        {
            string resultado = await client.GetStringAsync($"Redis/{txtGetChave.Text}");
            txtGetValor.Text = resultado;
        }
        private async Task RemoverRedis()
        {
            HttpResponseMessage response = await client.DeleteAsync($"Redis/{txtChave.Text}");
            string resultado = await response.Content.ReadAsStringAsync();
            MessageBox.Show(resultado);
        }

        private void btnSetar_Click(object sender, EventArgs e)
        {
            SetRedis();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            GetRedis();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverRedis();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            ShowTab("pgRedis");
        }
        void HideTabs(string namePage = null!)
        {
            if (!string.IsNullOrEmpty(namePage))
                foreach (XtraTabPage item in tclRedis.TabPages)
                {
                    if (item.Name == namePage)
                    {
                        item.Hide();
                        item.PageVisible = false;
                        return;
                    }
                }
            else
                foreach (XtraTabPage item in tclRedis.TabPages)
                {
                    item.Hide();
                    item.PageVisible = false;

                }
        }
        void ShowTab(string namePage = null!, bool hideAll = false)
        {
            if (!string.IsNullOrEmpty(namePage))
            {
                if (tclRedis.TabPages.Any(p => p.Name == namePage))
                {
                    if (hideAll)
                        HideTabs();
                    var pag = tclRedis.TabPages.FirstOrDefault(p => p.Name == namePage);
                    pag.Show();

                }
            }
            else
                foreach (XtraTabPage item in tclRedis.TabPages)
                {
                    item.Show();
                }

        }
        void Swagger()
        {

            string url = "https://localhost:44381/swagger";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void btnSwagger_Click(object sender, EventArgs e)
        {
            Swagger();
        }
    }
}
