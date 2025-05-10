using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordCreator
{
    /// <summary>
    /// パスワード生成
    /// </summary>
    public partial class PasswordCreator : Form
    {
        /// <summary>
        /// 数値最大値
        /// </summary>
        const int NUMBER_MAX_VALUE = 9;

        /// <summary>
        /// アルファベット大文字最大値
        /// </summary>
        const int ALPHABET_UP_MAX_VALUE = 26;

        /// <summary>
        /// アルファベット小文字最大値
        /// </summary>
        const int ALPHABET_LOW_MAX_VALUE = 26;

        /// <summary>
        /// 記号最大値
        /// </summary>
        const int SYMBOL_MAX_VALUE = 33;

        /// <summary>
        /// 数値初期値
        /// </summary>
        const string NUMBER_INIT_VALUE = "4";

        /// <summary>
        /// アルファベット大文字初期値
        /// </summary>
        const string ALPHABET_UP_INIT_VALUE = "4";

        /// <summary>
        /// アルファベット小文字初期値
        /// </summary>
        const string ALPHABET_LOW_INIT_VALUE = "4";

        /// <summary>
        /// 記号初期値
        /// </summary>
        const string SYMBOL_INIT_VALUE = "4";

        /// <summary>
        /// 数値データ
        /// </summary>
        const string NUMBER_DATA = "7152394608";

        /// <summary>
        /// アルファベット大文字データ
        /// </summary>
        const string ALPHABET_UP_DATA = "XBCSUEPZFYGHIJKAMNOQRTDVWL";

        /// <summary>
        /// アルファベット小文字データ
        /// </summary>
        const string ALPHABET_LOW_DATA = "ybdfgviqxjklmoczprsneahuwt";

        /// <summary>
        /// 記号データ「! \"#$%&'()*+,-./:;<=>?@[]^_`\\{|}~」
        /// </summary>
        const string SYMBOL_DATA = "@%+\\/!#$^?:.(){}~[]-_";

        /// <summary>
        /// コンストラクタ処理
        /// </summary>
        public PasswordCreator()
        {
            InitializeComponent();

            NumberCheckBox.Checked = true;
            AlphabetUPCheckBox.Checked = true;
            AlphabetLOWCheckBox.Checked = true;
            SymbolCheckBox.Checked = true;
            NumberTextBox.Text = NUMBER_INIT_VALUE;
            AlphabetUPTextBox.Text = ALPHABET_UP_INIT_VALUE;
            AlphabetLOWTextBox.Text = ALPHABET_LOW_INIT_VALUE;
            SymbolTextBox.Text = SYMBOL_INIT_VALUE;
            PasswordRichTextBox.Text = string.Empty;
            NumberDataTextBox.Text = NUMBER_DATA;
            AlphabetUPDataTextBox.Text = ALPHABET_UP_DATA;
            AlphabetLOWDataTextBox.Text = ALPHABET_LOW_DATA;
            SymbolDataTextBox.Text = SYMBOL_DATA;
        }

        /// <summary>
        /// ランダムパスワード生成ボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRandomButton_Click(object sender, EventArgs e)
        {
            List<string> passwordList = new List<string>();

            string passwordChars = null;
            int numberCnt = 0;

            if (NumberCheckBox.Checked && string.Empty != NumberDataTextBox.Text)
            {
                passwordChars = NumberDataTextBox.Text;

                int.TryParse(NumberTextBox.Text, out numberCnt);

                passwordList.AddRange(this.GetPassword(passwordChars, numberCnt));
            }

            if (AlphabetUPCheckBox.Checked && string.Empty != AlphabetUPDataTextBox.Text)
            {
                passwordChars = AlphabetUPDataTextBox.Text;

                int.TryParse(AlphabetUPTextBox.Text, out numberCnt);

                passwordList.AddRange(this.GetPassword(passwordChars, numberCnt));
            }

            if (AlphabetLOWCheckBox.Checked && string.Empty != AlphabetLOWDataTextBox.Text)
            {
                passwordChars = AlphabetLOWDataTextBox.Text;

                int.TryParse(AlphabetLOWTextBox.Text, out numberCnt);

                passwordList.AddRange(this.GetPassword(passwordChars, numberCnt));
            }

            if (SymbolCheckBox.Checked && string.Empty != SymbolDataTextBox.Text)
            {
                passwordChars = SymbolDataTextBox.Text;

                int.TryParse(SymbolTextBox.Text, out numberCnt);

                passwordList.AddRange(this.GetPassword(passwordChars, numberCnt));
            }

            string[] passwords = passwordList.OrderBy(i => Guid.NewGuid()).ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (string password in passwords)
            {
                sb.Append(password);
            }

            PasswordRichTextBox.Text = sb.ToString();
        }

        /// <summary>
        /// クリアボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            NumberCheckBox.Checked = false;
            AlphabetUPCheckBox.Checked = false;
            AlphabetLOWCheckBox.Checked = false;
            SymbolCheckBox.Checked = false;
            NumberTextBox.Text = string.Empty;
            AlphabetUPTextBox.Text = string.Empty;
            AlphabetLOWTextBox.Text = string.Empty;
            SymbolTextBox.Text = string.Empty;
            PasswordRichTextBox.Text = string.Empty;
            NumberDataTextBox.Text = string.Empty;
            AlphabetUPDataTextBox.Text = string.Empty;
            AlphabetLOWDataTextBox.Text = string.Empty;
            SymbolDataTextBox.Text = string.Empty;
        }

        /// <summary>
        /// 初期化ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitButton_Click(object sender, EventArgs e)
        {
            NumberCheckBox.Checked = true;
            AlphabetUPCheckBox.Checked = true;
            AlphabetLOWCheckBox.Checked = true;
            SymbolCheckBox.Checked = true;
            NumberTextBox.Text = NUMBER_INIT_VALUE;
            AlphabetUPTextBox.Text = ALPHABET_UP_INIT_VALUE;
            AlphabetLOWTextBox.Text = ALPHABET_LOW_INIT_VALUE;
            SymbolTextBox.Text = SYMBOL_INIT_VALUE;
            PasswordRichTextBox.Text = string.Empty;
            NumberDataTextBox.Text = NUMBER_DATA;
            AlphabetUPDataTextBox.Text = ALPHABET_UP_DATA;
            AlphabetLOWDataTextBox.Text = ALPHABET_LOW_DATA;
            SymbolDataTextBox.Text = SYMBOL_DATA;
        }

        /// <summary>
        /// 数値桁数変更時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            if (!int.TryParse(NumberTextBox.Text, out value))
            {
                int pos = NumberTextBox.Text.Length - 1;

                if (0 <= pos)
                {
                    NumberTextBox.Text = NumberTextBox.Text.Substring(0, pos);
                }
            }
            else
            {
                int max = 0;

                int.TryParse(NumberTextBox.Text, out max);

                if (NUMBER_MAX_VALUE < max)
                {
                    NumberTextBox.Text = NUMBER_MAX_VALUE.ToString();
                }
            }
        }

        /// <summary>
        /// アルファベット大文字桁数変更時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlphabetUPTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            if (!int.TryParse(AlphabetUPTextBox.Text, out value))
            {
                int pos = AlphabetUPTextBox.Text.Length - 1;

                if (0 <= pos)
                {
                    AlphabetUPTextBox.Text = AlphabetUPTextBox.Text.Substring(0, pos);
                }
            }
            else
            {
                int max = 0;

                int.TryParse(AlphabetUPTextBox.Text, out max);

                if (ALPHABET_UP_MAX_VALUE < max)
                {
                    AlphabetUPTextBox.Text = ALPHABET_UP_MAX_VALUE.ToString();
                }
            }
        }

        /// <summary>
        /// アルファベット小文字桁数変更時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlphabetLOWTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            if (!int.TryParse(AlphabetLOWTextBox.Text, out value))
            {
                int pos = AlphabetLOWTextBox.Text.Length - 1;

                if (0 <= pos)
                {
                    AlphabetLOWTextBox.Text = AlphabetLOWTextBox.Text.Substring(0, pos);
                }
            }
            else
            {
                int max = 0;

                int.TryParse(AlphabetLOWTextBox.Text, out max);

                if (ALPHABET_LOW_MAX_VALUE < max)
                {
                    AlphabetLOWTextBox.Text = ALPHABET_LOW_MAX_VALUE.ToString();
                }
            }
        }

        /// <summary>
        /// 記号桁数変更時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SymbolTextBox_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            if (!int.TryParse(SymbolTextBox.Text, out value))
            {
                int pos = SymbolTextBox.Text.Length - 1;

                if (0 <= pos)
                {
                    SymbolTextBox.Text = SymbolTextBox.Text.Substring(0, pos);
                }
            }
            else
            {
                int max = 0;

                int.TryParse(SymbolTextBox.Text, out max);

                if (SYMBOL_MAX_VALUE < max)
                {
                    SymbolTextBox.Text = SYMBOL_MAX_VALUE.ToString();
                }
            }
        }

        /// <summary>
        /// 数値データ変更時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberDataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// アルファベット大文字データ変更時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlphabetUPDataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'A' || 'Z' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// アルファベット小文字データ変更時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlphabetLOWDataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || 'z' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 記号データ変更時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SymbolDataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '!' || '/' < e.KeyChar)
                && (e.KeyChar < ':' || '@' < e.KeyChar)
                && (e.KeyChar < '[' || '\'' < e.KeyChar)
                && (e.KeyChar < '{' || '~' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// パスワード生成処理
        /// </summary>
        /// <param name="passwordChars"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        private List<string> GetPassword(string passwordChars, int num)
        {
            List<string> resultList = new List<string>();

            Random random = new Random();

            for (int i = 0; i < num; i++)
            {
                int pos = random.Next(passwordChars.Length);
                char c = passwordChars[pos];

                resultList.Add(c.ToString());
            }

            return resultList;
        }
    }
}
