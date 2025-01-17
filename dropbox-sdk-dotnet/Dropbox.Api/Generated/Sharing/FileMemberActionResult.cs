// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Per-member result for <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.AddFileMemberAsync" />.</para>
    /// </summary>
    public class FileMemberActionResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileMemberActionResult> Encoder = new FileMemberActionResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileMemberActionResult> Decoder = new FileMemberActionResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileMemberActionResult" />
        /// class.</para>
        /// </summary>
        /// <param name="member">One of specified input members.</param>
        /// <param name="result">The outcome of the action on this member.</param>
        public FileMemberActionResult(MemberSelector member,
                                      FileMemberActionIndividualResult result)
        {
            if (member == null)
            {
                throw new sys.ArgumentNullException("member");
            }

            if (result == null)
            {
                throw new sys.ArgumentNullException("result");
            }

            this.Member = member;
            this.Result = result;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileMemberActionResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileMemberActionResult()
        {
        }

        /// <summary>
        /// <para>One of specified input members.</para>
        /// </summary>
        public MemberSelector Member { get; protected set; }

        /// <summary>
        /// <para>The outcome of the action on this member.</para>
        /// </summary>
        public FileMemberActionIndividualResult Result { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileMemberActionResult" />.</para>
        /// </summary>
        private class FileMemberActionResultEncoder : enc.StructEncoder<FileMemberActionResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileMemberActionResult value, enc.IJsonWriter writer)
            {
                WriteProperty("member", value.Member, writer, global::Dropbox.Api.Sharing.MemberSelector.Encoder);
                WriteProperty("result", value.Result, writer, global::Dropbox.Api.Sharing.FileMemberActionIndividualResult.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileMemberActionResult" />.</para>
        /// </summary>
        private class FileMemberActionResultDecoder : enc.StructDecoder<FileMemberActionResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileMemberActionResult"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileMemberActionResult Create()
            {
                return new FileMemberActionResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileMemberActionResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "member":
                        value.Member = global::Dropbox.Api.Sharing.MemberSelector.Decoder.Decode(reader);
                        break;
                    case "result":
                        value.Result = global::Dropbox.Api.Sharing.FileMemberActionIndividualResult.Decoder.Decode(reader);
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
