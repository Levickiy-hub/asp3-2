namespace LAB_08.Models
{
    public class User
    {
        /// <summary>
        /// User Id
        /// </summary>
        /// <example>1</example>
        public int Id { get; set; }

        /// <summary>
        /// User Surname
        /// </summary>
        /// <example>Levickiy</example>
        public string LastName { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        /// <example>Slava</example>
        public string  FirstName { get; set; }

        /// <summary>
        /// User e-mail
        /// </summary>
        /// <example>levickiy@bk.ru</example>
        public string Email { get; set; }

        /// <summary>
        /// password
        /// </summary>
        /// <example>1111</example>
        public string Password { get; set; }

        /// <summary>
        /// active/passive
        /// </summary>
        /// <example>Active</example>
        public string Status { get; set; }

        /// <summary>
        /// admin/customer/HR
        /// </summary>
        /// <example>customer</example>
        public string Role { get; set; }
    }
}
