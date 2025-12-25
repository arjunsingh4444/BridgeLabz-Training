using System;

class OtpGenerate
{
    // Method for OTP
    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000); // 6-digit OTP
    }

    // Method to check whether all OTPs are unique
    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                    return false; // Duplicate found
            }
        }
        return true; // All OTPs are unique
    }

    
    static void Main()
    {
        int[] otps = new int[10];

        // Generate 10 OTPs
        for (int i = 0; i < otps.Length; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine("OTP " + (i + 1) + ": " + otps[i]);
        }

        // Check uniqueness
        bool result = AreOTPsUnique(otps);

        Console.WriteLine("\nAre all OTPs unique? " + result);
    }
}
