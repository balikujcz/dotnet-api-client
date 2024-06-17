/*
* Copyright (c) 2024 Balíkuj.cz
* http://balikuj.cz
*
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
*
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
*
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

namespace Balikuj.Client.Models.EmailAccount
{
    public class EmailAccountModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Host, e.g. smtp.email.cz
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Port, e.g. 587
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Your username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Your password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Enable SSL
        /// </summary>
        public bool EnableSsl { get; set; }

        //public bool UseDefaultCredentials { get; set; }

        /// <summary>
        /// Sets if you want to use this email account as default
        /// </summary>
        public bool IsDefaultEmailAccount { get; set; }
    }
}
