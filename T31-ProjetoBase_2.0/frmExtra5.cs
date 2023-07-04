using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T31_ProjetoBase
{
    public partial class frmExtra5 : Form
    {
        private bool isPlayerXTurn; // Variável para controlar de quem é a vez (X ou O)
        private int[,] gameBoard; // Tabuleiro do jogo da velha
        private Button[,] buttons; // Matriz para armazenar os botões
        private jogoDaVelha jogo;

        // Construtor
        public frmExtra5()
        {
            jogo = new jogoDaVelha();
            InitializeComponent();
        }

        // Método Load do formulário
        private void frmExtra5_Load(object sender, EventArgs e)
        {
            // Inicialize o jogo da velha
            isPlayerXTurn = true;
            gameBoard = new int[3, 3];
            buttons = new Button[3, 3]
            {
                { button1, button2, button3 },
                { button4, button5, button6 },
                { button7, button8, button9 }
            };

            // Adicione os manipuladores de eventos para cada botão
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    buttons[row, col].Click += Button_Click;
                }
            }
        }

        // Método do evento de clique de botão
        private void Button_Click(object sender, EventArgs e)
        {
            lblVez.Text = jogo.player(isPlayerXTurn); // Chamando o Metodo da CLASSE JOGODAVELHA PLAYER PARA SABER DE QUEM E A VEZ

            Button button = (Button)sender;
            int row = 0, col = 0;

            // Encontre a posição do botão na matriz
            for (row = 0; row < 3; row++)
            {
                for (col = 0; col < 3; col++)
                {
                    if (buttons[row, col] == button)
                    {
                        break;
                    }
                }
                if (col < 3)
                {
                    break;
                }
            }

            // Verifique se a posição já foi ocupada
            if (gameBoard[row, col] == 0)
            {
                // Marque a posição no tabuleiro
                gameBoard[row, col] = isPlayerXTurn ? 1 : 2;

                // Defina o texto do botão como X ou O
                button.Text = isPlayerXTurn ? "X" : "O";

                // Verifique se o jogo foi vencido
                if (CheckForWin(isPlayerXTurn))
                {
                    string winner = isPlayerXTurn ? "X" : "O";
                    MessageBox.Show($"O jogador {winner} venceu o jogo!");
                    ResetGame();
                    return;
                }

                // Verifique se houve empate
                if (Empate())
                {
                    MessageBox.Show("O jogo terminou em empate!");
                    ResetGame();
                    return;
                }

                // Troque a vez para o próximo jogador
                isPlayerXTurn = !isPlayerXTurn;
            }
        }

        // Método para verificar se houve vitória
        private bool CheckForWin(bool isPlayerX)
        {
            int player = isPlayerX ? 1 : 2;

            // Verifique todas as possibilidades de vitória
            for (int i = 0; i < 3; i++)
            {
                // Verifique linhas
                if (gameBoard[i, 0] == player && gameBoard[i, 1] == player && gameBoard[i, 2] == player)
                    return true;

                // Verifique colunas
                if (gameBoard[0, i] == player && gameBoard[1, i] == player && gameBoard[2, i] == player)
                    return true;
            }

            // Verifique diagonais
            if (gameBoard[0, 0] == player && gameBoard[1, 1] == player && gameBoard[2, 2] == player)
                return true;

            if (gameBoard[2, 0] == player && gameBoard[1, 1] == player && gameBoard[0, 2] == player)
                return true;

            return false;
        }

        // Método para verificar empate
        private bool Empate()
        {
            // Verifica se todas as posições do tabuleiro foram preenchidas
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (gameBoard[row, col] == 0)
                    {
                        return false; // Ainda há posições vazias, o jogo não está empatado
                    }
                }
            }

            return true; // Todas as posições estão preenchidas, o jogo está empatado
        }

        // Método para reiniciar o jogo
        private void ResetGame()
        {
            // Limpe o tabuleiro e os textos dos botões
            gameBoard = new int[3, 3];
            foreach (Button button in buttons)
            {
                button.Text = "";
            }

            // Reinicie a vez para o jogador X
            isPlayerXTurn = true;
        }
    }

    public class jogoDaVelha
    {
        private string xo; //ENCAPSULAMENTO

        // Construtor
        public jogoDaVelha()
        {
        }

        // Método para retornar o símbolo do jogador atual
        public string player(bool player)
        {
            if (player)
            {
                xo = "X";
                return xo;
            }
            else
            {
                xo = "O";
                return xo;
            }
        }
    }
}
