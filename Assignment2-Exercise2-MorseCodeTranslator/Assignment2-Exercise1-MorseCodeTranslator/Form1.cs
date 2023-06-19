namespace Assignment2_Exercise1_MorseCodeTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<char, string> morseCodeDictionary = new Dictionary<char, string>();
            morseCodeDictionary.Add(' ', " ");
            morseCodeDictionary.Add(',', "--..--");
            morseCodeDictionary.Add('.', ".-.-.-");
            morseCodeDictionary.Add('?', "..--..");
            morseCodeDictionary.Add('0', "-----");
            morseCodeDictionary.Add('1', ".----");
            morseCodeDictionary.Add('2', "..---");
            morseCodeDictionary.Add('3', "...--");
            morseCodeDictionary.Add('4', "....-");
            morseCodeDictionary.Add('5', ".....");
            morseCodeDictionary.Add('6', "-....");
            morseCodeDictionary.Add('7', "--...");
            morseCodeDictionary.Add('8', "---..");
            morseCodeDictionary.Add('9', "----.");
            morseCodeDictionary.Add('A', ".-");
            morseCodeDictionary.Add('B', "-...");
            morseCodeDictionary.Add('C', "-.-.");
            morseCodeDictionary.Add('D', "-..");
            morseCodeDictionary.Add('E', ".");
            morseCodeDictionary.Add('F', "..-.");
            morseCodeDictionary.Add('G', "--.");
            morseCodeDictionary.Add('H', "....");
            morseCodeDictionary.Add('I', "..");
            morseCodeDictionary.Add('J', ".");
            morseCodeDictionary.Add('K', "-.-");
            morseCodeDictionary.Add('L', ".-..");
            morseCodeDictionary.Add('M', "--");
            morseCodeDictionary.Add('N', "-.");
            morseCodeDictionary.Add('O', "---");
            morseCodeDictionary.Add('P', ".--.");
            morseCodeDictionary.Add('Q', "--.-");
            morseCodeDictionary.Add('R', ".-.");
            morseCodeDictionary.Add('S', "...");
            morseCodeDictionary.Add('T', "-");
            morseCodeDictionary.Add('U', "..-");
            morseCodeDictionary.Add('V', "...-");
            morseCodeDictionary.Add('W', ".--");
            morseCodeDictionary.Add('X', "-..-");
            morseCodeDictionary.Add('Y', "-.--");
            morseCodeDictionary.Add('Z', "--..");


            string userInput = textBox1.Text;
            string userInputToCapital = userInput.ToUpper();
            string morseWord = "";

            foreach (char character in userInputToCapital)
            {
                try
                {
                    string morseCode = morseCodeDictionary[character];
                    morseWord += morseCode;

                    textBox2.Text = morseWord;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please input a valid entry.", "Error");
                }
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}