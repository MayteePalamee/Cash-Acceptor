using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashAcceptor
{
    /// <summary>
    /// data convert
    /// </summary>
    public class ConvertHelper
    {
        /// <summary>
        /// Convert String binary to hex
        /// </summary>
        /// <param name="binary">binary pattern</param>
        /// <returns></returns>
        protected String ConvertBinaryToHex(String binary){
            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);
            int divide = binary.Length % 8;
            if (divide != 0){
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8){
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }
        /// <summary>
        /// Convert Hex to Byte
        /// </summary>
        /// <param name="hex">String Hex pattern</param>
        /// <returns>Byte</returns>
        protected Byte[] ConvertHexToByte(String hex) {
            hex = hex.Replace(" ", "");
            byte[] buffer = new byte[hex.Length / 2];

            for (int index = 0; index < hex.Length; index += 2) {
                buffer[index / 2] = (byte)Convert.ToByte(hex.Substring(index, 2), 16);
            }
            return buffer;
        }
        /// <summary>
        /// Convert byte to hex
        /// </summary>
        /// <param name="bytes">byte</param>
        /// <returns>String hex pattern</returns>
        protected String ConvertByteToHex(Byte bytes){

            return null;
        }
    }
}
