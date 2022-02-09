// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The upload session finish arg object</para>
    /// </summary>
    public class UploadSessionFinishArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UploadSessionFinishArg> Encoder = new UploadSessionFinishArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UploadSessionFinishArg> Decoder = new UploadSessionFinishArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionFinishArg" />
        /// class.</para>
        /// </summary>
        /// <param name="cursor">Contains the upload session ID and the offset.</param>
        /// <param name="commit">Contains the path and other optional modifiers for the
        /// commit.</param>
        /// <param name="contentHash">NOT YET SUPPORTED. A hash of the file content uploaded in
        /// this call. If provided and the uploaded content does not match this hash, an error
        /// will be returned. For more information see our <a
        /// href="https://www.dropbox.com/developers/reference/content-hash">Content hash</a>
        /// page.</param>
        public UploadSessionFinishArg(UploadSessionCursor cursor,
                                      CommitInfo commit,
                                      string contentHash = null)
        {
            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }

            if (commit == null)
            {
                throw new sys.ArgumentNullException("commit");
            }

            if (contentHash != null)
            {
                if (contentHash.Length < 64)
                {
                    throw new sys.ArgumentOutOfRangeException("contentHash", "Length should be at least 64");
                }
                if (contentHash.Length > 64)
                {
                    throw new sys.ArgumentOutOfRangeException("contentHash", "Length should be at most 64");
                }
            }

            this.Cursor = cursor;
            this.Commit = commit;
            this.ContentHash = contentHash;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionFinishArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UploadSessionFinishArg()
        {
        }

        /// <summary>
        /// <para>Contains the upload session ID and the offset.</para>
        /// </summary>
        public UploadSessionCursor Cursor { get; protected set; }

        /// <summary>
        /// <para>Contains the path and other optional modifiers for the commit.</para>
        /// </summary>
        public CommitInfo Commit { get; protected set; }

        /// <summary>
        /// <para>NOT YET SUPPORTED. A hash of the file content uploaded in this call. If
        /// provided and the uploaded content does not match this hash, an error will be
        /// returned. For more information see our <a
        /// href="https://www.dropbox.com/developers/reference/content-hash">Content hash</a>
        /// page.</para>
        /// </summary>
        public string ContentHash { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UploadSessionFinishArg" />.</para>
        /// </summary>
        private class UploadSessionFinishArgEncoder : enc.StructEncoder<UploadSessionFinishArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UploadSessionFinishArg value, enc.IJsonWriter writer)
            {
                WriteProperty("cursor", value.Cursor, writer, global::Dropbox.Api.Files.UploadSessionCursor.Encoder);
                WriteProperty("commit", value.Commit, writer, global::Dropbox.Api.Files.CommitInfo.Encoder);
                if (value.ContentHash != null)
                {
                    WriteProperty("content_hash", value.ContentHash, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UploadSessionFinishArg" />.</para>
        /// </summary>
        private class UploadSessionFinishArgDecoder : enc.StructDecoder<UploadSessionFinishArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UploadSessionFinishArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UploadSessionFinishArg Create()
            {
                return new UploadSessionFinishArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UploadSessionFinishArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "cursor":
                        value.Cursor = global::Dropbox.Api.Files.UploadSessionCursor.Decoder.Decode(reader);
                        break;
                    case "commit":
                        value.Commit = global::Dropbox.Api.Files.CommitInfo.Decoder.Decode(reader);
                        break;
                    case "content_hash":
                        value.ContentHash = enc.StringDecoder.Instance.Decode(reader);
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
