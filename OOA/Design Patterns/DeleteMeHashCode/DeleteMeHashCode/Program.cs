using System.Security.Cryptography;
using System.Text;

string password = "qwerty123";
string salt = "W+ynecj6X7TaW+jVo19cGw==";

//Console.WriteLine(GenerateSha256(password, salt));
//Console.WriteLine("faaf82c81a19035218eabcf879c9c07073cc2db0cde7b3a624a0a2e5a18ebb94");

System.Console.WriteLine(ComputeSha256Hash(password+salt));

static string ComputeSha256Hash(string rawData)  
{  
    // Create a SHA256   
    using (SHA256 sha256Hash = SHA256.Create())  
    {  
        // ComputeHash - returns byte array  
        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  

        // Convert byte array to a string   
        StringBuilder builder = new StringBuilder();  
        for (int i = 0; i < bytes.Length; i++)  
        {  
            builder.Append(bytes[i].ToString("x2"));  
        }  
        return builder.ToString();  
    }  
}  