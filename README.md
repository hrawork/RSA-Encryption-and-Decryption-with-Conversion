# 🔐 RSA Encryption and Decryption with Binary, Decimal, and Hexadecimal Conversion (WinForms App)

This Windows Forms application provides a simple GUI for **RSA encryption and decryption** along with **conversion tools** to view cipher output in **binary**, **decimal**, and **hexadecimal** formats.

---

## 🚀 Features

- ✅ RSA Key Generation (with custom prime inputs `p` and `q`)
- ✅ Text Encryption using Public Key `(e, n)`
- ✅ Text Decryption using Private Key `(d, n)`
- ✅ View Encrypted Text as:
  - Decimal
  - Binary
  - Hexadecimal
- ✅ Easy-to-use GUI built with Windows Forms (C#)
- ✅ Error handling for invalid input and formats

---

## 🖥️ Technologies Used

- C#
- Windows Forms (.NET 6.0 / .NET Framework)
- RSA Algorithm (simplified for learning/demo purposes)
- System.Text & System.Security.Cryptography

---

## 🔑 How RSA Works Here

1. You enter two prime numbers (`p`, `q`) and click **Generate Keys**.
2. App calculates:
   - Modulus `n = p * q`
   - Public Key exponent `e`
   - Private Key exponent `d`
3. You enter a plaintext message and click **Encrypt**:
   - The message is encrypted using `e` and `n`.
   - Output is shown in decimal form.
   - Can also be converted to binary or hex.
4. You paste or type the cipher into the decryption box and click **Decrypt**:
   - Cipher is decrypted using `d` and `n` to recover the original message.

---

## 🧪 Sample Test

Use the following values to test the encryption/decryption:

```plaintext
p = 61
q = 53

Message: Hello
