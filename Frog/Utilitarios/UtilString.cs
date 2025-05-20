using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.MonthCalendar;

namespace Frog.Utilitarios
{
    public class UtilString
    {
        public string RecuperarBlocoTextoDoCursor(TextBox txtArea)
        {
            // Pega todas as linhas do TextBox
            var lines = txtArea.Lines;
            int cursorIndex = txtArea.SelectionStart;

            // Determina em qual linha o cursor está
            int currentLine = txtArea.GetLineFromCharIndex(cursorIndex);

            // Define os limites do bloco
            int startLine = currentLine;
            int endLine = currentLine;

            // Subir até encontrar linha em branco ou topo
            while (startLine > 0 && !string.IsNullOrWhiteSpace(lines[startLine - 1]))
            {
                startLine--;
            }

            // Descer até encontrar linha em branco ou final
            while (endLine < lines.Length - 1 && !string.IsNullOrWhiteSpace(lines[endLine + 1]))
            {
                endLine++;
            }

            // Junta as linhas do bloco
            var blockLines = lines.Skip(startLine).Take(endLine - startLine + 1);
            return string.Join(Environment.NewLine, blockLines);
        }

        public string RecuperarPalavraDoCursor(TextBox txtArea)
        {
            int startIndex = txtArea.SelectionStart;
            string texto = txtArea.Text;

            int inicioPalavra = startIndex;
            while (inicioPalavra > 0 && !char.IsWhiteSpace(texto[inicioPalavra - 1]))
            {
                inicioPalavra--;
            }

            int fimPalavra = startIndex;
            while (fimPalavra < texto.Length && !char.IsWhiteSpace(texto[fimPalavra]))
            {
                fimPalavra++;
            }

            return texto.Substring(inicioPalavra, fimPalavra - inicioPalavra);
        }

        public void ColorirSQL(RichTextBox richTextBox)
        {
            string[] palavrasReservadas = { "SELECT", "FROM", "WHERE", "INSERT", "UPDATE", "DELETE", "CALL" };

            // Salva a posição atual do cursor
            int selStart = richTextBox.SelectionStart;
            int selLength = richTextBox.SelectionLength;

            richTextBox.SuspendLayout();

            // Remove coloração anterior
            richTextBox.SelectAll();
            richTextBox.SelectionColor = Color.Black;

            // Colore palavras reservadas
            foreach (var palavra in palavrasReservadas)
            {
                int startIndex = 0;
                while ((startIndex = richTextBox.Text.IndexOf(palavra, startIndex, StringComparison.OrdinalIgnoreCase)) != -1)
                {
                    richTextBox.Select(startIndex, palavra.Length);
                    richTextBox.SelectionColor = Color.Blue;
                    startIndex += palavra.Length;
                }
            }

            // Restaura o cursor
            richTextBox.SelectionStart = selStart;
            richTextBox.SelectionLength = selLength;
            richTextBox.SelectionColor = Color.Black;

            richTextBox.ResumeLayout();
        }
    }
}
