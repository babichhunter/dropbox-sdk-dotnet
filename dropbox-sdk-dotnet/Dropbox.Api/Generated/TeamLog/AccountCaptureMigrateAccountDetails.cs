// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Account-captured user migrated account to team.</para>
    /// </summary>
    public class AccountCaptureMigrateAccountDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AccountCaptureMigrateAccountDetails> Encoder = new AccountCaptureMigrateAccountDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AccountCaptureMigrateAccountDetails> Decoder = new AccountCaptureMigrateAccountDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="AccountCaptureMigrateAccountDetails" /> class.</para>
        /// </summary>
        /// <param name="domainName">Domain name.</param>
        public AccountCaptureMigrateAccountDetails(string domainName)
        {
            if (domainName == null)
            {
                throw new sys.ArgumentNullException("domainName");
            }

            this.DomainName = domainName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="AccountCaptureMigrateAccountDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public AccountCaptureMigrateAccountDetails()
        {
        }

        /// <summary>
        /// <para>Domain name.</para>
        /// </summary>
        public string DomainName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AccountCaptureMigrateAccountDetails" />.</para>
        /// </summary>
        private class AccountCaptureMigrateAccountDetailsEncoder : enc.StructEncoder<AccountCaptureMigrateAccountDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AccountCaptureMigrateAccountDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("domain_name", value.DomainName, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AccountCaptureMigrateAccountDetails" />.</para>
        /// </summary>
        private class AccountCaptureMigrateAccountDetailsDecoder : enc.StructDecoder<AccountCaptureMigrateAccountDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="AccountCaptureMigrateAccountDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AccountCaptureMigrateAccountDetails Create()
            {
                return new AccountCaptureMigrateAccountDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(AccountCaptureMigrateAccountDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "domain_name":
                        value.DomainName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}