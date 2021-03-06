// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Paper
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The add member object</para>
    /// </summary>
    public class AddMember
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AddMember> Encoder = new AddMemberEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AddMember> Decoder = new AddMemberDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AddMember" /> class.</para>
        /// </summary>
        /// <param name="member">User which should be added to the Paper doc. Specify only
        /// email or Dropbox account id.</param>
        /// <param name="permissionLevel">Permission for the user.</param>
        public AddMember(global::Dropbox.Api.Sharing.MemberSelector member,
                         PaperDocPermissionLevel permissionLevel = null)
        {
            if (member == null)
            {
                throw new sys.ArgumentNullException("member");
            }

            if (permissionLevel == null)
            {
                permissionLevel = global::Dropbox.Api.Paper.PaperDocPermissionLevel.Edit.Instance;
            }
            this.Member = member;
            this.PermissionLevel = permissionLevel;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AddMember" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public AddMember()
        {
            this.PermissionLevel = global::Dropbox.Api.Paper.PaperDocPermissionLevel.Edit.Instance;
        }

        /// <summary>
        /// <para>User which should be added to the Paper doc. Specify only email or Dropbox
        /// account id.</para>
        /// </summary>
        public global::Dropbox.Api.Sharing.MemberSelector Member { get; protected set; }

        /// <summary>
        /// <para>Permission for the user.</para>
        /// </summary>
        public PaperDocPermissionLevel PermissionLevel { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="AddMember" />.</para>
        /// </summary>
        private class AddMemberEncoder : enc.StructEncoder<AddMember>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AddMember value, enc.IJsonWriter writer)
            {
                WriteProperty("member", value.Member, writer, global::Dropbox.Api.Sharing.MemberSelector.Encoder);
                WriteProperty("permission_level", value.PermissionLevel, writer, global::Dropbox.Api.Paper.PaperDocPermissionLevel.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="AddMember" />.</para>
        /// </summary>
        private class AddMemberDecoder : enc.StructDecoder<AddMember>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AddMember" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AddMember Create()
            {
                return new AddMember();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(AddMember value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "member":
                        value.Member = global::Dropbox.Api.Sharing.MemberSelector.Decoder.Decode(reader);
                        break;
                    case "permission_level":
                        value.PermissionLevel = global::Dropbox.Api.Paper.PaperDocPermissionLevel.Decoder.Decode(reader);
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
