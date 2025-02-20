using Gma.System.MouseKeyHook;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCupom
{
    public partial class AutoCupom: Form
    {
        private IKeyboardMouseEvents HookManager;
        private Keys teclaAtivacao;
        private bool executando = false;
        private bool status = false;

        public AutoCupom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HookManager = Hook.GlobalEvents();
        }

        private void txtTeclaAtivacao_KeyDown(object sender, KeyEventArgs e)
        {
            teclaAtivacao = e.KeyCode; // Captura a tecla pressionada
            txtTeclaAtivacao.Text = teclaAtivacao.ToString(); // Exibe a tecla no TextBox
            e.SuppressKeyPress = true; // Impede que a tecla apareça no TextBox de forma repetida
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (teclaAtivacao == Keys.None)
            {
                MessageBox.Show("Por favor, defina uma tecla para executar o macro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AtualizarStatus(true);
            HookManager.KeyDown += HookManager_KeyDown;
            MessageBox.Show("Macro ativado! Pressione " + teclaAtivacao.ToString() + " para executar.");
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            executando = false;
            MessageBox.Show("Macro interrompido!");
            AtualizarStatus(false);
        }

        private void lnkOngameCupom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://pb.ongame.net/cupons",
                UseShellExecute = true
            });
        }

        private void AtualizarStatus(bool status)
        {
            if (status)
            {
                lblStatus.Text = "Status: ON";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                this.status = true;
            }
            else
            {
                lblStatus.Text = "Status: OFF";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                this.status = false;
            }
        }

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == teclaAtivacao)
            {
                #region Loop OFF

                //if (executando && chkLoop.Checked)
                //{
                //    executando = false;
                //    chkLoop.Checked = false;
                //    MessageBox.Show("Macro interrompido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    AtualizarStatus(false);
                //}

                #endregion

                if (status)
                {
                    executando = true;
                    Thread macroThread = new Thread(ExecutarMacro);
                    macroThread.Start();
                }
            }
        }

        public void ExecutarMacro()
        {
            InputSimulator.LeftClick();
            Task.Delay(100).Wait();
            InputSimulator.LeftClick();

            InputSimulator.CtrlC();
            Task.Delay(25).Wait();

            InputSimulator.AltTab();
            Task.Delay(25).Wait();

            InputSimulator.CtrlV();
            Task.Delay(100).Wait();

            InputSimulator.PressEnter();

            #region Loop OFF

            //do
            //{
            //    if (!executando) break;

            //    InputSimulator.LeftClick();
            //    Task.Delay(50).Wait();

            //    InputSimulator.LeftClick();
            //    Task.Delay(50).Wait();

            //    InputSimulator.CtrlC();
            //    Task.Delay(50).Wait();

            //    InputSimulator.AltTab();
            //    Task.Delay(50).Wait();

            //    InputSimulator.CtrlV();
            //    Task.Delay(50).Wait();

            //    InputSimulator.PressEnter();
            //    Task.Delay(50).Wait();

            //} while (chkLoop.Checked && executando);

            #endregion
        }
    }
}
