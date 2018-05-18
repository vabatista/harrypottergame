using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace HarryPotterGame
{

    

    public partial class InitialForm : Form
    {
        private static QuestionFactory questionFactoryInstance;
        private static Random rnd = new Random();

        public static int whoAnsweredCorrect = 0;

        private int timeLeft = 60;
        private Question currentQuestion;
        

        private int currentTeam = 1;
        private int pontosEquipe1 = 0;
        private int pontosEquipe2 = 0;

        private int pontuacaoJogo = 15;

        private List<Control> panelsPuzzle;

        public InitialForm()
        {
            InitializeComponent();
            
            questionFactoryInstance = new QuestionFactory(@"..\..\..\..\data\questions.csv");
            questionFactoryInstance.LoadQuestions();

            timer.Interval = 1000;

            CarregaListaPaineis(false);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timerLabel.Text = timeLeft.ToString();
                if (timeLeft<10)
                {
                    timerLabel.ForeColor = Color.Red;
                }

                if (timeLeft % 3 == 0 && panelsPuzzle.Count > 0)
                {
                    int idx = rnd.Next(panelsPuzzle.Count);
                    Control p = panelsPuzzle[idx];
                    p.Visible = false;
                    panelsPuzzle.RemoveAt(idx);
                }

            }
            else
            {
                timer.Stop();

                MostrarResposta();
            }
        }

        private void MostrarResposta()
        {
            timer.Stop();
            txtResposta.Text = currentQuestion.Answer;
            txtResposta.Visible = true;
            AvaliarResposta();
        }

        private void AvaliarResposta()
        {
            
            if (currentQuestion.QuestionType == Question.QuestionTypeEnum.CHARACTER || currentQuestion.QuestionType == Question.QuestionTypeEnum.SCENE)
            {
                CarregaListaPaineis(false);
            }
            if (currentQuestion.QuestionType == Question.QuestionTypeEnum.CHARACTER)
            {
                Who frm = new Who();
                frm.ShowDialog(this);
                frm.Dispose();

                if (whoAnsweredCorrect == 1)
                {
                    pontosEquipe1++;
                    txtPontosEquipe1.Text = pontosEquipe1.ToString();
                }
                else if (whoAnsweredCorrect == 2)
                {
                    pontosEquipe2++;
                    txtPontosEquipe2.Text = pontosEquipe2.ToString();
                }
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("A equipe acertou a resposta?", "Acertaram?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (currentTeam==1)
                    {
                        pontosEquipe1++;
                        txtPontosEquipe1.Text = pontosEquipe1.ToString();
                    } else
                    {
                        pontosEquipe2++;
                        txtPontosEquipe2.Text = pontosEquipe2.ToString();
                    }
                }
            }
            if (currentTeam == 1)
            {
                currentTeam = 2;
            }
            else
            {
                currentTeam = 1;
            }
            txtPergunta.Visible = false;
            txtResposta.Visible = false;
            imgPergunta.Visible = false;
            timerLabel.Visible = false;
            btMostrarResposta.Enabled = false;
            btSortear.Enabled = true;
            

            if (pontosEquipe1 == pontuacaoJogo)
            {
                MessageBox.Show("A Grifinólia é a campeã!", "Temos um vencedor", MessageBoxButtons.OK);
                Application.Exit();
            } 
            if (pontosEquipe2 == pontuacaoJogo)
            {
                MessageBox.Show("A Sonserina é a campeã!", "Temos um vencedor", MessageBoxButtons.OK);
                Application.Exit();
            }
            
        }

        private void SortearEquipes()
        {
            List<String> participantes = new List<String>();
            participantes.Add("Manu Lestrange");
            participantes.Add("Artur Snape");
            participantes.Add("Vitor olho tonto");
            participantes.Add("Gabriela Delacour");
            participantes.Add("Gabriel Weasley");
            participantes.Add("João Potter");
            txtEquipe1.Text = "";
            txtEquipe2.Text = "";
            Random rnd = new Random();
            int i = 0;
            while (participantes.Count > 0)
            {
                int idx = rnd.Next(participantes.Count);
                String participante = participantes[idx];
                if (i % 2 == 0)
                {
                    txtEquipe1.Text = txtEquipe1.Text + participante + "\n";
                } else
                {
                    txtEquipe2.Text = txtEquipe2.Text + participante + "\n";
                }
                participantes.RemoveAt(idx);
                i++;
            }

        }

 
        private void SortearPergunta()
        {
            timeLeft = 60;
            timerLabel.Text = "60";
            currentQuestion = questionFactoryInstance.ChooseNextQuestion();
            if (currentQuestion == null)
            {
                MessageBox.Show("Acabaram as perguntas :-(", "Fim do Jogo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            txtPergunta.Text = currentQuestion.QuestionText;
            if (currentQuestion.QuestionType == Question.QuestionTypeEnum.CHARACTER || currentQuestion.QuestionType == Question.QuestionTypeEnum.SCENE)
            {
                imgPergunta.Image = Image.FromFile(currentQuestion.ImagePath);
                imgPergunta.Visible = true;

                CarregaListaPaineis(true);
            } else
            {
                CarregaListaPaineis(false);
            }
            txtPergunta.Visible = true;
            timerLabel.Visible = true;
            timerLabel.ForeColor = Color.Black;
            txtPergunta.ForeColor = Color.Black;

            if (currentQuestion.QuestionType == Question.QuestionTypeEnum.CHARACTER)
            {
                txtEquipe1.BorderStyle = BorderStyle.FixedSingle;
                txtEquipe2.BorderStyle = BorderStyle.FixedSingle;
                txtEquipe1.BackColor = Color.Pink;
                txtEquipe2.BackColor = Color.Pink;
                btSortear.Enabled = false;
                btMostrarResposta.Enabled = false;
            }
            else
            {
                if (currentTeam == 1)
                {
                    txtEquipe1.BorderStyle = BorderStyle.FixedSingle;
                    txtEquipe1.BackColor = Color.Pink;
                    txtEquipe2.BorderStyle = BorderStyle.None;
                    txtEquipe2.BackColor = Color.White;
                }
                else
                {
                    txtEquipe2.BorderStyle = BorderStyle.FixedSingle;
                    txtEquipe2.BackColor = Color.Pink;
                    txtEquipe1.BorderStyle = BorderStyle.None;
                    txtEquipe1.BackColor = Color.White;
                }
            }
            timer.Start();
            btMostrarResposta.Enabled = true;
        }

        private void CarregaListaPaineis(Boolean visivel)
        {
            panelsPuzzle = new List<Control>();
            panelsPuzzle.Add(panel1);
            panelsPuzzle.Add(panel2);
            panelsPuzzle.Add(panel3);
            panelsPuzzle.Add(panel4);
            panelsPuzzle.Add(panel5);
            panelsPuzzle.Add(panel6);
            panelsPuzzle.Add(panel7);
            panelsPuzzle.Add(panel8);
            panelsPuzzle.Add(panel9);
            panelsPuzzle.Add(panel10);
            panelsPuzzle.Add(panel11);
            panelsPuzzle.Add(panel12);
            panelsPuzzle.Add(panel13);
            panelsPuzzle.Add(panel14);
            panelsPuzzle.Add(panel15);
            panelsPuzzle.Add(panel16);
            panelsPuzzle.Add(panel17);
            panelsPuzzle.Add(panel18);
            foreach (Control p in panelsPuzzle)
            {
                p.Visible = visivel;
            }
            
        }

        private void IniciarJogo()
        {
            SortearEquipes();
            txtPontosEquipe1.Text = "0";
            txtPontosEquipe2.Text = "0";
            pontosEquipe1 = 0;
            pontosEquipe2 = 0;
            btSortear.Enabled = true;
        }

        private void btIniciarJogo_Click(object sender, EventArgs e)
        {
            IniciarJogo();
        }

        private void btSortear_Click(object sender, EventArgs e)
        {
            SortearPergunta();
        }

        private void btMostrarResposta_Click(object sender, EventArgs e)
        {
            MostrarResposta();
        }

        private void imgPergunta_Click(object sender, EventArgs e)
        {

        }
    }
}
