
using System.Text;

namespace diamond_kata
{
    public class DiamondKata
    {
        public static string GenerateDiamond(char c)
        {
            int size = c - 'A' + 1;
            StringBuilder diamondBuilder = new StringBuilder();

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size * 2 - 1; col++)
                {
                    if (col == size - 1 - row || col == size - 1 + row)
                    {
                        diamondBuilder.Append((char)('A' + row));
                    }
                    else
                    {
                        diamondBuilder.Append('_');
                    }
                }

                diamondBuilder.AppendLine(); // Move to the next line after each row
            }

            for (int row = size - 2; row >= 0; row--)
            {
                for (int col = 0; col < size * 2 - 1; col++)
                {
                    if (col == size - 1 - row || col == size - 1 + row)
                    {
                        diamondBuilder.Append((char)('A' + row));
                    }
                    else
                    {
                        diamondBuilder.Append('_');
                    }
                }

                diamondBuilder.AppendLine(); // Move to the next line after each row
            }

            return diamondBuilder.ToString();
        }
    }
}