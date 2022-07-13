/******************************************************************************
**  Copyright(c) 2022 ignackoo. All rights reserved.
**
**  Licensed under the MIT license.
**  See LICENSE file in the project root for full license information.
**
**  This file is a part of the C# Library Base64.
** 
**  Base64 coding
**
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class Base64
    {
        /// <summary>
        /// Base 64 Encode string.
        /// </summary>
        /// <param name="plaintext">Plain text.</param>
        /// <returns>Base 64 text.</returns>
        public static string EncodeString(string plaintext)
        {
            if (String.IsNullOrEmpty(plaintext)) return (String.Empty);
            byte[] textbytes = System.Text.Encoding.UTF8.GetBytes(plaintext);
            return (Convert.ToBase64String(textbytes));
        }

        /// <summary>
        /// Base 64 Decode string.
        /// </summary>
        /// <param name="base64text">Base 64 text.</param>
        /// <returns>Plain text.</returns>
        public static string DecodeString(string base64text)
        {
            if (String.IsNullOrEmpty(base64text)) return (String.Empty);
            byte[] base64bytes = Convert.FromBase64String(base64text);
            return (System.Text.Encoding.UTF8.GetString(base64bytes));
        }


        /// <summary>
        /// Base 64 Encode byte array.
        /// </summary>
        /// <param name="bytearray">Byte Array.</param>
        /// <returns>Base 64 text.</returns>
        public static string EncodeByteArray(byte[] bytearray)
        {
            return (Convert.ToBase64String(bytearray));
        }

        /// <summary>
        /// Base 64 decode byte array.
        /// </summary>
        /// <param name="base64text">Base 64 text.</param>
        /// <returns>Byte Array.</returns>
        public static byte[] DecodeByteArray(string base64text)
        {
            return (Convert.FromBase64String(base64text));
        }
    }
}
