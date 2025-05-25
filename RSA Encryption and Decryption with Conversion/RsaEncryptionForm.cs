using System;
using System.Text;
using System.Windows.Forms;

namespace RSA_Encryption_and_Decryption_with_Conversion
{
    public partial class RsaEncryptionForm : Form
    {
        private long n, y, d;
        private long[] encryptedMessage;

        public RsaEncryptionForm()
        {
            InitializeComponent();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                if (!long.TryParse(txtP.Text, out long p) || !long.TryParse(txtQ.Text, out long q))
                {
                    MessageBox.Show("Invalid input! P and Q must be numbers.");
                    return;
                }

                if (p == q)
                {
                    MessageBox.Show("P and Q must be distinct primes.");
                    return;
                }

                if (!IsPrime(p) || !IsPrime(q))
                {
                    MessageBox.Show("Both P and Q must be prime numbers.");
                    return;
                }

                GenerateKeys(p, q, out n, out y, out d);

                if (n <= 255)
                {
                    MessageBox.Show("N is too small. Choose larger prime numbers.");
                    return;
                }

                txtN.Text = n.ToString();
                txtE.Text = y.ToString();
                txtD.Text = d.ToString();

                MessageBox.Show("Keys generated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in key generation: " + ex.Message);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlainText.Text))
            {
                MessageBox.Show("Enter a message to encrypt.");
                return;
            }

            if (n == 0 || y == 0)
            {
                MessageBox.Show("Generate keys first.");
                return;
            }

            encryptedMessage = Encrypt(txtPlainText.Text, y, n);
            StringBuilder cipherText = new StringBuilder();

            foreach (var c in encryptedMessage)
                cipherText.Append(c + " ");

            string output = cipherText.ToString().Trim();
            txtCipherText.Text = output;
            txtConversionInput.Text = output;

            // Optional: Show Base64 representation of raw bytes
            // Commented to avoid confusion with symbol display
            // string base64Cipher = Convert.ToBase64String(Encoding.UTF8.GetBytes(output));
            // MessageBox.Show("Base64 Representation:\n" + base64Cipher, "Optional Cipher Format");
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCipherInput.Text))
                {
                    MessageBox.Show("Enter cipher text to decrypt.");
                    return;
                }

                string[] parts = txtCipherInput.Text.Trim().Split(' ');
                long[] inputCipher = new long[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    if (!long.TryParse(parts[i], out inputCipher[i]))
                    {
                        MessageBox.Show("Invalid format: Cipher text must contain numbers separated by spaces.");
                        return;
                    }
                }

                string decryptedText = Decrypt(inputCipher, d, n);
                txtDecrypted.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption failed: " + ex.Message);
            }
        }

        // Core RSA Functions

        private void GenerateKeys(long p, long q, out long n, out long e, out long d)
        {
            n = p * q;
            long phi = (p - 1) * (q - 1);
            e = 3;

            while (GCD(e, phi) != 1)
                e += 2;

            d = ModInverse(e, phi);
        }

        private bool IsPrime(long number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (long i = 3; i * i <= number; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        private long GCD(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private long ModInverse(long a, long m)
        {
            long m0 = m, y = 0, x = 1;

            if (m == 1) return 0;

            while (a > 1)
            {
                long q = a / m;
                long t = m;
                m = a % m;
                a = t;

                t = y;
                y = x - q * y;
                x = t;
            }

            return x < 0 ? x + m0 : x;
        }

        private long ModPow(long baseVal, long exponent, long modulus)
        {
            long result = 1;
            baseVal %= modulus;

            while (exponent > 0)
            {
                if ((exponent & 1) == 1)
                    result = (result * baseVal) % modulus;

                exponent >>= 1;
                baseVal = (baseVal * baseVal) % modulus;
            }

            return result;
        }

        private long[] Encrypt(string message, long e, long n)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            long[] cipher = new long[bytes.Length];

            for (int i = 0; i < bytes.Length; i++)
                cipher[i] = ModPow(bytes[i], e, n);

            return cipher;
        }

        private string Decrypt(long[] cipher, long d, long n)
        {
            byte[] bytes = new byte[cipher.Length];

            for (int i = 0; i < cipher.Length; i++)
            {
                long decryptedValue = ModPow(cipher[i], d, n);
                if (decryptedValue < 0 || decryptedValue > 255)
                    throw new Exception($"Decrypted value out of byte range: {decryptedValue}");

                bytes[i] = (byte)decryptedValue;
            }

            return Encoding.UTF8.GetString(bytes);
        }

        // Conversion Buttons

        private void btnToBinary_Click(object sender, EventArgs e)
        {
            string[] numbers = txtConversionInput.Text.Split(' ');
            StringBuilder result = new StringBuilder();

            foreach (var number in numbers)
            {
                if (long.TryParse(number, out long value))
                    result.Append(Convert.ToString(value, 2).PadLeft(8, '0') + " ");
            }

            txtConvertedOutput.Text = result.ToString().Trim();
        }

        private void btnToHex_Click(object sender, EventArgs e)
        {
            string[] numbers = txtConversionInput.Text.Split(' ');
            StringBuilder result = new StringBuilder();

            foreach (var number in numbers)
            {
                if (long.TryParse(number, out long value))
                    result.Append(Convert.ToString(value, 16).ToUpper().PadLeft(2, '0') + " ");
            }

            txtConvertedOutput.Text = result.ToString().Trim();
        }

        private void btnToDecimal_Click(object sender, EventArgs e)
        {
            txtConvertedOutput.Text = txtConversionInput.Text;
        }

        private void label10_Click(object sender, EventArgs e) { }
    }
}
