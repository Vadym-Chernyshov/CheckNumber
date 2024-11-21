namespace CheckNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ввід дкорситувача
            Console.WriteLine("Please write your number");
            string usersInput = Console.ReadLine();

            string BasicTextForWin = "Conversion to the specified type was successful"; //базовий текст при успішному переведені
            string BasicTextForDefeat = "Conversion to the specified type failed"; //базовий текст при помилці переведення

            Console.WriteLine();
            Console.WriteLine("Check...");
            //INT
            try
            {
                int parseUsersInput = int.Parse(usersInput);
                Console.WriteLine($"INT: {BasicTextForWin}.\nResult: {parseUsersInput}");
            }
            catch (FormatException ex) { Console.WriteLine($"INT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (OverflowException ex) { Console.WriteLine($"INT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (ArgumentNullException ex) { Console.WriteLine($"INT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"INT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            Console.WriteLine();
            //UINT
            try
            {
                uint parseUsersInput = uint.Parse(usersInput);
                Console.WriteLine($"UINT: {BasicTextForWin}.\nResult: {parseUsersInput}");
            }
            catch (FormatException ex) { Console.WriteLine($"UINT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (OverflowException ex) { Console.WriteLine($"UINT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (ArgumentNullException ex) { Console.WriteLine($"UINT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"UINT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            Console.WriteLine();
            //SBYTE
            try
            {
                sbyte parseUsersInput = sbyte.Parse(usersInput);
                Console.WriteLine($"SBYTE: {BasicTextForWin}.\nResult: {parseUsersInput}");
            }
            catch (FormatException ex) { Console.WriteLine($"SBYTE: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (OverflowException ex) { Console.WriteLine($"SBYTE: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (ArgumentNullException ex) { Console.WriteLine($"SBYTE: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"SBYTE: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            Console.WriteLine();
            //BYTE
            try
            {
                byte parseUsersInput = byte.Parse(usersInput);
                Console.WriteLine($"BYTE: {BasicTextForWin}.\nResult: {parseUsersInput}");
            }
            catch (FormatException ex) { Console.WriteLine($"BYTE: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (OverflowException ex) { Console.WriteLine($"BYTE: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (ArgumentNullException ex) { Console.WriteLine($"BYTE: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"BYTE: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            Console.WriteLine();
            //SHORT
            try
            {
                short parseUsersInput = short.Parse(usersInput);
                Console.WriteLine($"SHORT: {BasicTextForWin}.\nResult: {parseUsersInput}");
            }
            catch (FormatException ex) { Console.WriteLine($"SHORT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (OverflowException ex) { Console.WriteLine($"SHORT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (ArgumentNullException ex) { Console.WriteLine($"SHORT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"SHORT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            Console.WriteLine();
            //USHORT
            try
            {
                ushort parseUsersInput = ushort.Parse(usersInput);
                Console.WriteLine($"USHORT: {BasicTextForWin}.\nResult: {parseUsersInput}");
            }
            catch (FormatException ex) { Console.WriteLine($"USHORT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (OverflowException ex) { Console.WriteLine($"USHORT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (ArgumentNullException ex) { Console.WriteLine($"USHORT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"USHORT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            Console.WriteLine();
            //LONG
            try
            {
                long parseUsersInput = long.Parse(usersInput);
                Console.WriteLine($"LONG: {BasicTextForWin}.\nResult: {parseUsersInput}");
            }
            catch (FormatException ex) { Console.WriteLine($"LONG: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (OverflowException ex) { Console.WriteLine($"LONG: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (ArgumentNullException ex) { Console.WriteLine($"LONG: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"LONG: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            Console.WriteLine();
            //ULONG
            try
            {
                ulong parseUsersInput = ulong.Parse(usersInput);
                Console.WriteLine($"ULONG: {BasicTextForWin}.\nResult: {parseUsersInput}");
            }
            catch (FormatException ex) { Console.WriteLine($"ULONG: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (OverflowException ex) { Console.WriteLine($"ULONG: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (ArgumentNullException ex) { Console.WriteLine($"ULONG: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"ULONG: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            Console.WriteLine();
            //FLOAT
            try
            {
                float parseUsersInput = float.Parse(usersInput);
                Console.WriteLine($"FLOAT: {BasicTextForWin}.\nResult: {parseUsersInput}");
            }
            catch (FormatException ex) { Console.WriteLine($"FLOAT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (OverflowException ex) { Console.WriteLine($"FLOAT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (ArgumentNullException ex) { Console.WriteLine($"FLOAT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"FLOAT: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            Console.WriteLine();
            //DOUBLE
            try
            {
                double parseUsersInput = double.Parse(usersInput);
                Console.WriteLine($"DOUBLE: {BasicTextForWin}.\nResult: {parseUsersInput}");
            }
            catch (FormatException ex) { Console.WriteLine($"DOUBLE: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (OverflowException ex) { Console.WriteLine($"DOUBLE: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (ArgumentNullException ex) { Console.WriteLine($"DOUBLE: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"DOUBLE: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            Console.WriteLine();
            //DECIMAL
            try
            {
                decimal parseUsersInput = decimal.Parse(usersInput);
                Console.WriteLine($"DECIMAL: {BasicTextForWin}.\nResult: {parseUsersInput}");
            }
            catch (FormatException ex) { Console.WriteLine($"DECIMAL: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (OverflowException ex) { Console.WriteLine($"DECIMAL: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (ArgumentNullException ex) { Console.WriteLine($"DECIMAL: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            catch (Exception ex) { Console.WriteLine($"DECIMAL: {BasicTextForDefeat}.\nError:{ex.Message}"); }
            Console.WriteLine();

        }
    }
}
