/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes a destination in Amazon Redshift.
    /// </summary>
    public partial class RedshiftDestinationDescription
    {
        private string _clusterJDBCURL;
        private CopyCommand _copyCommand;
        private string _roleARN;
        private S3DestinationDescription _s3DestinationDescription;
        private string _username;

        /// <summary>
        /// Gets and sets the property ClusterJDBCURL. 
        /// <para>
        /// The database connection string.
        /// </para>
        /// </summary>
        public string ClusterJDBCURL
        {
            get { return this._clusterJDBCURL; }
            set { this._clusterJDBCURL = value; }
        }

        // Check to see if ClusterJDBCURL property is set
        internal bool IsSetClusterJDBCURL()
        {
            return this._clusterJDBCURL != null;
        }

        /// <summary>
        /// Gets and sets the property CopyCommand. 
        /// <para>
        /// The <code>COPY</code> command.
        /// </para>
        /// </summary>
        public CopyCommand CopyCommand
        {
            get { return this._copyCommand; }
            set { this._copyCommand = value; }
        }

        // Check to see if CopyCommand property is set
        internal bool IsSetCopyCommand()
        {
            return this._copyCommand != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The ARN of the AWS credentials.
        /// </para>
        /// </summary>
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationDescription. 
        /// <para>
        /// The Amazon S3 destination.
        /// </para>
        /// </summary>
        public S3DestinationDescription S3DestinationDescription
        {
            get { return this._s3DestinationDescription; }
            set { this._s3DestinationDescription = value; }
        }

        // Check to see if S3DestinationDescription property is set
        internal bool IsSetS3DestinationDescription()
        {
            return this._s3DestinationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The name of the user.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}