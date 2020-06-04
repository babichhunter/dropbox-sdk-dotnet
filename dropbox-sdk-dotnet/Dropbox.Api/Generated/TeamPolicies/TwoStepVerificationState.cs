// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamPolicies
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The two step verification state object</para>
    /// </summary>
    public class TwoStepVerificationState
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TwoStepVerificationState> Encoder = new TwoStepVerificationStateEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TwoStepVerificationState> Decoder = new TwoStepVerificationStateDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TwoStepVerificationState" />
        /// class.</para>
        /// </summary>
        public TwoStepVerificationState()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Required</para>
        /// </summary>
        public bool IsRequired
        {
            get
            {
                return this is Required;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Required, or <c>null</c>.</para>
        /// </summary>
        public Required AsRequired
        {
            get
            {
                return this as Required;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Optional</para>
        /// </summary>
        public bool IsOptional
        {
            get
            {
                return this is Optional;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Optional, or <c>null</c>.</para>
        /// </summary>
        public Optional AsOptional
        {
            get
            {
                return this as Optional;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Disabled</para>
        /// </summary>
        public bool IsDisabled
        {
            get
            {
                return this is Disabled;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Disabled, or <c>null</c>.</para>
        /// </summary>
        public Disabled AsDisabled
        {
            get
            {
                return this as Disabled;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TwoStepVerificationState" />.</para>
        /// </summary>
        private class TwoStepVerificationStateEncoder : enc.StructEncoder<TwoStepVerificationState>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TwoStepVerificationState value, enc.IJsonWriter writer)
            {
                if (value is Required)
                {
                    WriteProperty(".tag", "required", writer, enc.StringEncoder.Instance);
                    Required.Encoder.EncodeFields((Required)value, writer);
                    return;
                }
                if (value is Optional)
                {
                    WriteProperty(".tag", "optional", writer, enc.StringEncoder.Instance);
                    Optional.Encoder.EncodeFields((Optional)value, writer);
                    return;
                }
                if (value is Disabled)
                {
                    WriteProperty(".tag", "disabled", writer, enc.StringEncoder.Instance);
                    Disabled.Encoder.EncodeFields((Disabled)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TwoStepVerificationState" />.</para>
        /// </summary>
        private class TwoStepVerificationStateDecoder : enc.UnionDecoder<TwoStepVerificationState>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TwoStepVerificationState"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TwoStepVerificationState Create()
            {
                return new TwoStepVerificationState();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override TwoStepVerificationState Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "required":
                        return Required.Decoder.DecodeFields(reader);
                    case "optional":
                        return Optional.Decoder.DecodeFields(reader);
                    case "disabled":
                        return Disabled.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Enabled require two factor authorization.</para>
        /// </summary>
        public sealed class Required : TwoStepVerificationState
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Required> Encoder = new RequiredEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Required> Decoder = new RequiredDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Required" /> class.</para>
            /// </summary>
            private Required()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Required</para>
            /// </summary>
            public static readonly Required Instance = new Required();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Required" />.</para>
            /// </summary>
            private class RequiredEncoder : enc.StructEncoder<Required>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Required value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Required" />.</para>
            /// </summary>
            private class RequiredDecoder : enc.StructDecoder<Required>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Required" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Required Create()
                {
                    return Required.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Optional require two factor authorization.</para>
        /// </summary>
        public sealed class Optional : TwoStepVerificationState
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Optional> Encoder = new OptionalEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Optional> Decoder = new OptionalDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Optional" /> class.</para>
            /// </summary>
            private Optional()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Optional</para>
            /// </summary>
            public static readonly Optional Instance = new Optional();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Optional" />.</para>
            /// </summary>
            private class OptionalEncoder : enc.StructEncoder<Optional>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Optional value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Optional" />.</para>
            /// </summary>
            private class OptionalDecoder : enc.StructDecoder<Optional>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Optional" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Optional Create()
                {
                    return Optional.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Disabled require two factor authorization.</para>
        /// </summary>
        public sealed class Disabled : TwoStepVerificationState
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Disabled> Encoder = new DisabledEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Disabled> Decoder = new DisabledDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Disabled" /> class.</para>
            /// </summary>
            private Disabled()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Disabled</para>
            /// </summary>
            public static readonly Disabled Instance = new Disabled();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Disabled" />.</para>
            /// </summary>
            private class DisabledEncoder : enc.StructEncoder<Disabled>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Disabled value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Disabled" />.</para>
            /// </summary>
            private class DisabledDecoder : enc.StructDecoder<Disabled>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Disabled" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Disabled Create()
                {
                    return Disabled.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : TwoStepVerificationState
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}