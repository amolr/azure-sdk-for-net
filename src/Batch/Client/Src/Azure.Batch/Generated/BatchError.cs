// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An error received from the Azure Batch service.
    /// </summary>
    public partial class BatchError : IPropertyMetadata
    {
        private readonly string code;
        private readonly ErrorMessage message;
        private readonly IReadOnlyList<BatchErrorDetail> values;

        #region Constructors

        internal BatchError(Models.BatchError protocolObject)
        {
            this.code = protocolObject.Code;
            this.message = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Message, o => new ErrorMessage(o).Freeze());
            this.values = BatchErrorDetail.ConvertFromProtocolCollectionReadOnly(protocolObject.Values);
        }

        #endregion Constructors

        #region BatchError

        /// <summary>
        /// Gets a code for the error. See <see cref="Common.BatchErrorCodeStrings"/> for possible values.
        /// </summary>
        public string Code
        {
            get { return this.code; }
        }

        /// <summary>
        /// Gets a message describing the error, intended to be suitable for display in a user interface.
        /// </summary>
        public ErrorMessage Message
        {
            get { return this.message; }
        }

        /// <summary>
        /// Gets a collection of key-value pairs containing additional details about the error.
        /// </summary>
        public IReadOnlyList<BatchErrorDetail> Values
        {
            get { return this.values; }
        }

        #endregion // BatchError

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}