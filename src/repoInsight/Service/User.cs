using System.Security.Cryptography;
using repoInsight.Models;

namespace repoInsight.Services;

public static class PasswordEncryptor
{
    // Define the number of iterations for the key derivation function
    private const int Iterations = 100000; // A more secure iteration count

    // Define the size of the salt and hash
    private const int SaltSize = 16; // 128-bit
    private const int HashSize = 32; // 256-bit (SHA-256 hash)

    // Method to encrypt the password
    public static string ToPassword(this Usuario usuario, string? password = null)
    {
        string pass = password ?? usuario.Senha;
        // Generate a salt
        byte[] salt = new byte[SaltSize];
        RandomNumberGenerator.Fill(salt);

        // Generate the hash
        using var pbkdf2 = new Rfc2898DeriveBytes(pass, salt, Iterations, HashAlgorithmName.SHA256);
        byte[] hash = pbkdf2.GetBytes(HashSize);

        // Combine the salt and hash for storage
        byte[] hashBytes = new byte[SaltSize + HashSize];
        Array.Copy(salt, 0, hashBytes, 0, SaltSize);
        Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

        // Convert to Base64 for storage
        string encryptedPassword = Convert.ToBase64String(hashBytes);

        return encryptedPassword;
    }

    // Method to verify a password against a stored hash
    public static bool VerifyPassword(this Usuario usuario, string enteredPassword)
    {
        // Extract the bytes from the stored hash
        byte[] hashBytes = Convert.FromBase64String(usuario.Senha);

        // Get the salt from the stored hash
        byte[] salt = new byte[SaltSize];
        Array.Copy(hashBytes, 0, salt, 0, SaltSize);

        // Hash the entered password with the stored salt
        using var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, Iterations, HashAlgorithmName.SHA256);
        byte[] hash = pbkdf2.GetBytes(HashSize);

        // Compare the results
        for (int i = 0; i < HashSize; i++)
        {
            if (hashBytes[i + SaltSize] != hash[i])
            {
                return false;
            }
        }
        return true;
    }
}
