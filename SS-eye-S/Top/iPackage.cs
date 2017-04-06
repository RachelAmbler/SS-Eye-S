// ***********************************************************************
// Assembly         : SSeyeS
// Author           : RandomThunks
// Created          : 03-04-2014
//
// Last Modified By : Rachel Ambler
// Last Modified On : 03-21-2014
// ***********************************************************************
#region Apache License 2.0
/*
Apache License 2.0 (Apache)
Apache License
Version 2.0, January 2004
http://www.apache.org/licenses/

TERMS AND CONDITIONS FOR USE, REPRODUCTION, AND DISTRIBUTION

1. Definitions.

"License" shall mean the terms and conditions for use, reproduction, and distribution as defined by Sections 1 through 9 of this document.

"Licensor" shall mean the copyright owner or entity authorized by the copyright owner that is granting the License.

"Legal Entity" shall mean the union of the acting entity and all other entities that control, are controlled by, or are under common control with that entity. For the purposes of this definition, "control" means (i) the power, direct or indirect, to cause the direction or management of such entity, whether by contract or otherwise, or (ii) ownership of fifty percent (50%) or more of the outstanding shares, or (iii) beneficial ownership of such entity.

"You" (or "Your") shall mean an individual or Legal Entity exercising permissions granted by this License.

"Source" form shall mean the preferred form for making modifications, including but not limited to software source code, documentation source, and configuration files.

"Object" form shall mean any form resulting from mechanical transformation or translation of a Source form, including but not limited to compiled object code, generated documentation, and conversions to other media types.

"Work" shall mean the work of authorship, whether in Source or Object form, made available under the License, as indicated by a copyright notice that is included in or attached to the work (an example is provided in the Appendix below).

"Derivative Works" shall mean any work, whether in Source or Object form, that is based on (or derived from) the Work and for which the editorial revisions, annotations, elaborations, or other modifications represent, as a whole, an original work of authorship. For the purposes of this License, Derivative Works shall not include works that remain separable from, or merely link (or bind by name) to the interfaces of, the Work and Derivative Works thereof.

"Contribution" shall mean any work of authorship, including the original version of the Work and any modifications or additions to that Work or Derivative Works thereof, that is intentionally submitted to Licensor for inclusion in the Work by the copyright owner or by an individual or Legal Entity authorized to submit on behalf of the copyright owner. For the purposes of this definition, "submitted" means any form of electronic, verbal, or written communication sent to the Licensor or its representatives, including but not limited to communication on electronic mailing lists, source code control systems, and issue tracking systems that are managed by, or on behalf of, the Licensor for the purpose of discussing and improving the Work, but excluding communication that is conspicuously marked or otherwise designated in writing by the copyright owner as "Not a Contribution."

"Contributor" shall mean Licensor and any individual or Legal Entity on behalf of whom a Contribution has been received by Licensor and subsequently incorporated within the Work.

2. Grant of Copyright License.

Subject to the terms and conditions of this License, each Contributor hereby grants to You a perpetual, worldwide, non-exclusive, no-charge, royalty-free, irrevocable copyright license to reproduce, prepare Derivative Works of, publicly display, publicly perform, sublicense, and distribute the Work and such Derivative Works in Source or Object form.

3. Grant of Patent License.

Subject to the terms and conditions of this License, each Contributor hereby grants to You a perpetual, worldwide, non-exclusive, no-charge, royalty-free, irrevocable (except as stated in this section) patent license to make, have made, use, offer to sell, sell, import, and otherwise transfer the Work, where such license applies only to those patent claims licensable by such Contributor that are necessarily infringed by their Contribution(s) alone or by combination of their Contribution(s) with the Work to which such Contribution(s) was submitted. If You institute patent litigation against any entity (including a cross-claim or counterclaim in a lawsuit) alleging that the Work or a Contribution incorporated within the Work constitutes direct or contributory patent infringement, then any patent licenses granted to You under this License for that Work shall terminate as of the date such litigation is filed.

4. Redistribution.

You may reproduce and distribute copies of the Work or Derivative Works thereof in any medium, with or without modifications, and in Source or Object form, provided that You meet the following conditions:

1. You must give any other recipients of the Work or Derivative Works a copy of this License; and

2. You must cause any modified files to carry prominent notices stating that You changed the files; and

3. You must retain, in the Source form of any Derivative Works that You distribute, all copyright, patent, trademark, and attribution notices from the Source form of the Work, excluding those notices that do not pertain to any part of the Derivative Works; and

4. If the Work includes a "NOTICE" text file as part of its distribution, then any Derivative Works that You distribute must include a readable copy of the attribution notices contained within such NOTICE file, excluding those notices that do not pertain to any part of the Derivative Works, in at least one of the following places: within a NOTICE text file distributed as part of the Derivative Works; within the Source form or documentation, if provided along with the Derivative Works; or, within a display generated by the Derivative Works, if and wherever such third-party notices normally appear. The contents of the NOTICE file are for informational purposes only and do not modify the License. You may add Your own attribution notices within Derivative Works that You distribute, alongside or as an addendum to the NOTICE text from the Work, provided that such additional attribution notices cannot be construed as modifying the License.

You may add Your own copyright statement to Your modifications and may provide additional or different license terms and conditions for use, reproduction, or distribution of Your modifications, or for any such Derivative Works as a whole, provided Your use, reproduction, and distribution of the Work otherwise complies with the conditions stated in this License.

5. Submission of Contributions.

Unless You explicitly state otherwise, any Contribution intentionally submitted for inclusion in the Work by You to the Licensor shall be under the terms and conditions of this License, without any additional terms or conditions. Notwithstanding the above, nothing herein shall supersede or modify the terms of any separate license agreement you may have executed with Licensor regarding such Contributions.

6. Trademarks.

This License does not grant permission to use the trade names, trademarks, service marks, or product names of the Licensor, except as required for reasonable and customary use in describing the origin of the Work and reproducing the content of the NOTICE file.

7. Disclaimer of Warranty.

Unless required by applicable law or agreed to in writing, Licensor provides the Work (and each Contributor provides its Contributions) on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied, including, without limitation, any warranties or conditions of TITLE, NON-INFRINGEMENT, MERCHANTABILITY, or FITNESS FOR A PARTICULAR PURPOSE. You are solely responsible for determining the appropriateness of using or redistributing the Work and assume any risks associated with Your exercise of permissions under this License.

8. Limitation of Liability.

In no event and under no legal theory, whether in tort (including negligence), contract, or otherwise, unless required by applicable law (such as deliberate and grossly negligent acts) or agreed to in writing, shall any Contributor be liable to You for damages, including any direct, indirect, special, incidental, or consequential damages of any character arising as a result of this License or out of the use or inability to use the Work (including but not limited to damages for loss of goodwill, work stoppage, computer failure or malfunction, or any and all other commercial damages or losses), even if such Contributor has been advised of the possibility of such damages.

9. Accepting Warranty or Additional Liability.

While redistributing the Work or Derivative Works thereof, You may choose to offer, and charge a fee for, acceptance of support, warranty, indemnity, or other liability obligations and/or rights consistent with this License. However, in accepting such obligations, You may act only on Your own behalf and on Your sole responsibility, not on behalf of any other Contributor, and only if You agree to indemnify, defend, and hold each Contributor harmless for any liability incurred by, or claims asserted against, such Contributor by reason of your accepting any such warranty or additional liability.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.Dts.Runtime;
using System.Security.Cryptography.X509Certificates;


namespace RandomThunks.API.SSiS
{
    /// <summary>
    /// Class iPackage. This class is the base class used to define an SSIS package and escapulates
    /// the <see cref="Microsoft.SqlServer.Dts.Runtime.Package"/> and <see cref="Microsoft.SqlServer.Dts.Runtime.Application"/> classes.
    /// </summary>
    public class iPackage : IContainer, IDisposable
    {
        /// <summary>
        /// The internal <see cref="Microsoft.SqlServer.Dts.Runtime.Application"/> used by this package.
        /// </summary>
        private readonly Application _application;
        /// <summary>
        /// The path the contains the filename the package will be saved to.
        /// </summary>
        private readonly string _path;
        /// <summary>
        /// An internal list of Connections used in the package.
        /// </summary>
        private SortedList<string, iConnection> _connections;
        /// <summary>
        /// The internal <see cref="Microsoft.SqlServer.Dts.Runtime.Package"/> used by this package.
        /// </summary>
        private Package _package;
       
        SortedList<string, iVariable> _variables;
        #region Disposable Implementation
        /// <summary>
        /// Finalizes an instance of the <see cref="iPackage"/> class.
        /// </summary>
        ~iPackage()
        {
            Dispose(false);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                if (_package != null)
                {
                    _package.Dispose();
                    _package = null;
                }
        }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="iPackage"/> class.
        /// </summary>
        /// <param name="path">The path to save the DTSX package to.</param>
        /// <param name="load">Unused.</param>
        [ObsoleteAttribute("This constructor is obsolete. Call new iPackage(path) instead.", false)] 
        public iPackage(string path, bool load):this(path)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="iPackage"/> class that has data protected by a password.
        /// </summary>
        /// <param name="password">The <c>string</c> that contains the password used to encrypt the
        /// contents of the package. See also <see cref="iProtectionLevel"/>.</param>
        /// <param name="path">A <c>string</c> that contains the path to save the DTSX package to.</param>
        /// <param name="load">Unused.</param>
        [ObsoleteAttribute("This constructor is obsolete. Call new iPackage(password, path) instead.", false)] 
        public iPackage(string password, string path, bool load): this(password, path)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="iPackage"/> class.
        /// </summary>
        /// <param name="path">The path to save the DTSX package to.</param>
        public iPackage(string path)
            : this(string.Empty, path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="iPackage"/> class that has data protected by a password.
        /// </summary>
        /// <param name="password">The <c>string</c> that contains the password used to encrypt the
        /// contents of the package. See also <see cref="iProtectionLevel"/>.</param>
        /// <param name="path">A <c>string</c> that contains the path to save the DTSX package to.</param>
        public iPackage(string password, string path)
        {
            _path = path;
            _application = new Application();
            _package = new Package();
            _variables = new SortedList<string, iVariable>();
            _connections = new SortedList<string, iConnection>();

            if (password != string.Empty)
            {
                Password = password;
            }

            //if (load)
            //{
            //    _package.LoadFromXML(path, null);
            //}
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="iPackage"/> class from being created.
        /// </summary>
        private iPackage()
        {
            // Hide from use.
        }

        /// <summary>
        /// Specifies values that describe if, or when, a package is restarted.
        /// </summary>
        public enum CheckpointUsage
        {
            /// <summary>
            /// Specifies that the package never restarts. This is the default value.
            /// </summary>
            Never = 0,
            /// <summary>
            /// Specifies that the package restarts if the file specified by the <see cref="CheckpointFileName"/>.
            /// is found.
            /// </summary>
            IfExists = 1,
            /// <summary>
            /// Specifies that the package always restarts.
            /// </summary>
            Always = 2,
        }


        /// <summary>
        /// Controls the handling of sensitive information in the package.
        /// </summary>
        public enum iProtectionLevel
        {
            /// <summary>
            /// Sensitive information is not saved in the package. The sensitive information
            /// is removed and replaced with blanks.
            /// </summary>
            DontSaveSensitive = 0,
            /// <summary>
            /// Encrypts sensitive properties only by using keys based on the current user.
            /// Only the same user using the same profile can load the package. If a different
            /// user opens the package, the sensitive information is replaced with blanks.
            /// DPAPI is used for this encryption.
            /// </summary>
            EncryptSensitiveWithUserKey = 1,
            /// Encrypts only sensitive information contained in the package by using a password.
            /// DPAPI is used for this encryption.
            /// <summary>
            /// The encrypt sensitive with password
            /// </summary>
            EncryptSensitiveWithPassword = 2,
            /// <summary>
            /// Encrypts the entire package by using a password.
            /// </summary>
            EncryptAllWithPassword = 3,
            /// <summary>
            /// Encrypts the entire package by using keys based on the user profile. Only
            /// the same user using the same profile can load the package.
            /// </summary>
            EncryptAllWithUserKey = 4,
            /// <summary>
            /// Encrypts the package within a SQL Server msdb database. This option is supported
            /// only when a package is saved to SQL Server. It is not supported when a package
            /// is saved to the File System. The access control of who can decrypt the package
            /// is controlled by SQL Server database roles. For more information, see Database-Level
            /// Roles and sysssispackages (Transact-SQL).
            /// </summary>
            ServerStorage = 5,
        }
        
        /// <summary>
        /// Describes the status of the digital signature.
        /// </summary>
        public enum SignatureStatus
        {
            /// <summary>
            /// The signature is not valid.
            /// </summary>
            Invalid = 0,
            /// <summary>
            /// The signature is not present.
            /// </summary>
            NotPresent = 1,
            /// <summary>
            /// The signature is valid.
            /// </summary>
            Good = 2,
            /// <summary>
            /// The signature is from an untrusted source.
            /// </summary>
            Untrusted = 3,
        }

        /// <summary>
        /// Gets or sets the certificate context.
        /// </summary>
        /// <value>The certificate context.</value>
        public long CertificateContext
        {
            get
            {
                return _package.CertificateContext;
            }
            set
            {
                _package.CertificateContext = value;
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Security.Cryptography.X509Certificates.X509Certificate2">X509. certificate</see> object for the package.
        /// </summary>
        /// <value>The <see cref="System.Security.Cryptography.X509Certificates.X509Certificate2">X509. certificate</see> object for the package.</value>
        public X509Certificate CertificateObject
        {
            get
            {
                return _package.CertificateObject;
            }
            set
            {
                _package.CertificateObject = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the file that captures the checkpoint information, which enables a package to restart.
        /// </summary>
        /// <value>The name of the file that captures the checkpoint information.</value>
        public string CheckpointFileName
        {
            get
            {
                return Package.CheckpointFileName;
            }
            set
            {
                Package.CheckpointFileName = value;
            }
        }

        /// <summary>
        /// Gets or sets a value that specifies if or when a package is restarted.
        /// </summary>
        /// <value>A value from the <see cref="CheckpointUsage"/> enumeration. </value>
        public CheckpointUsage CheckPointUsage
        {
            get
            {
                return (CheckpointUsage)Package.CheckpointUsage;
            }
            set
            {
                Package.CheckpointUsage = (DTSCheckpointUsage)value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the digital signature is checked when a package is loaded.
        /// </summary>
        /// <value><c>true</c> if the digital signature is validated when the package is loaded; otherwise, <c>false</c>. The default value is <c>true</c>.</value>
        public bool CheckSignatureOnLoad
        {
            get
            {
                return _package.CheckSignatureOnLoad;
            }
            set
            {
                _package.CheckSignatureOnLoad = value;
            }
        }

        /// <summary>
        /// GGets or sets the date and time that the package was created.
        /// </summary>
        /// <value>The date and time that the package was created.</value>
        public DateTime CreationDate
        {
            get
            {
                return Package.CreationDate;
            }
            set
            {
                Package.CreationDate = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the computer on which the package was created.
        /// </summary>
        /// <value>The name of the computer.</value>
        public string CreatorComputerName
        {
            get
            {
                return Package.CreatorComputerName;
            }
            set
            {
                Package.CreatorComputerName = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the individual who created the package.
        /// </summary>
        /// <value>The name of the individual who created the package.</value>
        public string CreatorName
        {
            get
            {
                return Package.CreatorName;
            }
            set
            {
                Package.CreatorName = value;
            }
        }

        /// <summary>
        /// Gets or sets a <c>Boolean</c> that indicates whether validation of the task is delayed until run time. The default value is <c>false</c>.
        /// </summary>
        /// <value><c>true</c> if validation of the package is delayed until run time. <c>false</c> if the package is validated, and errors and warnings are returned
        /// before the package is actually executed. <c>false</c> may prevent the package from running if errors or warnings occur that exceed the
        /// <see cref="MaximumErrorCount"/>property.</value>
        public bool DelayValidation
        {
            get
            {
                return _package.DelayValidation;
            }
            set
            {
                _package.DelayValidation = value;
            }
        }

        /// <summary>
        /// Gets or sets the description of the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/> object.
        /// </summary>
        /// <value>A <c>String</c>c> that contains the description given to the container.</value>
        public string Description
        {
            get
            {
                return Package.Description;
            }
            set
            {
                Package.Description = value;
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the checkpoint files are encrypted.
        /// </summary>
        /// <value><c>true</c>  if the checkpoint files are encrypted; otherwise, <c>false</c>.</value>
        public bool EncryptCheckpoints
        {
            get
            {
                return Package.EncryptCheckpoints;
            }
            set
            {
                Package.EncryptCheckpoints = value;
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the package fails when a task or component in the package fails.
        /// </summary>
        /// <value><c>true</c> if the package fails when a task or component in the package fails; otherwise, <c>false</c>.</value>
        public bool FailPackageOnFailure
        {
            get
            {
                return Package.FailPackageOnFailure;
            }
            set
            {
                Package.FailPackageOnFailure = value;
            }
        }

        /// <summary>
        /// Gets or sets a Boolean that defines whether the parent container fails when a child container fails.
        /// </summary>
        /// <value>A <c>Boolean</c> that indicates whether the package fails if an error occurs in a child
        /// container. The default value of this property is <c>false</c>.</value>
        /// <remarks>
        /// If FailParentOnFailure is <c>true</c> and the execution result of a container is failure,
        /// the execution result of failure is assigned to the parent container. For more information,
        /// see <seealso href="http://msdn.microsoft.com/en-us/library/ms140226(v=sql.120).aspx">Restart Packages by Using Checkpoints</seealso>.
        /// </remarks>
        public bool FailParentOnFailure
        {
            get
            {
                return Package.FailParentOnFailure;
            }
            set
            {
                Package.FailParentOnFailure = value;
            }
        }

        /// <summary>
        /// Gets or sets an Integer value that indicates the maximum number of errors that can
        /// occur before the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/> object stops running.
        /// </summary>
        /// <value>An <c>Integer</c> that indicates the maximum number of errors allowed. The default value of this property is 1.</value>
        public int MaximumErrorCount
        {
            get
            {
                return Package.MaximumErrorCount;
            }
            set
            {
                Package.MaximumErrorCount = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.
        /// </summary>
        /// <value>A <c>String</c> that indicates the name of the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</value>
        public string Name
        {
            get
            {
                return Package.Name;
            }
            set
            {
                Package.Name = value;
            }
        }

        /// <summary>
        /// Sets the value of the password for the package. This property is write-only.
        /// </summary>
        /// <value>A <c>String</c> that contains the password for the package.</value>
        public string Password
        {
            set
            {
                _application.PackagePassword = value;
                _package.PackagePassword = value;

                if (value != string.Empty && (ProtectionLevel != iProtectionLevel.EncryptAllWithPassword && ProtectionLevel != iProtectionLevel.EncryptSensitiveWithPassword))
                    ProtectionLevel = iProtectionLevel.EncryptSensitiveWithPassword;
            }
        }

        /// <summary>
        /// Gets the level of protection on the package.
        /// </summary>
        /// <value>A value from the <see cref="iProtectionLevel"/> enumeration.</value>
        public iProtectionLevel ProtectionLevel
        {
            get
            {
                return (iProtectionLevel)_package.ProtectionLevel;
            }
            set
            {
                _package.ProtectionLevel = (DTSProtectionLevel)value;
            }
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the package will use checkpoints during package execution.
        /// </summary>
        /// <value><c>true</c> if the package uses checkpoints during package execution; otherwise <c>false</c>.</value>
        public bool SaveCheckpoints
        {
            get
            {
                return Package.SaveCheckpoints;
            }
            set
            {
                Package.SaveCheckpoints = value;
            }
        }

        /// <summary>
        /// Gets or sets the build version of the package.
        /// </summary>
        /// <value>The build version of the package.</value>
        public int VersionBuild
        {
            get
            {
                return Package.VersionBuild;
            }
            set
            {
                Package.VersionBuild = value;
            }
        }

        /// <summary>
        /// Gets the version comments associated with the package.
        /// </summary>
        /// <value>The <c>String</c> that contains version comments for the package.</value>
        public string VersionComments
        {
            get
            {
                return Package.VersionComments;
            }
            set
            {
                Package.VersionComments = value;
            }
        }

        /// <summary>
        /// Gets the version GUID generated when the package is first created. This field is read-only.
        /// </summary>
        /// <value>A <c>String</c> representation of the version GUID for the package.</value>
        public string VersionGUID
        {
            get
            {
                return Package.VersionGUID;
            }
        }

        /// <summary>
        /// Gets the major build version of the package.
        /// </summary>
        /// <value>The major build version of the package.</value>
        public int VersionMajor
        {
            get
            {
                return Package.VersionMajor;
            }
            set
            {
                Package.VersionMajor = value;
            }
        }

        /// <summary>
        /// Gets the minor build version of the package.
        /// </summary>
        /// <value>The minor build version of the package.</value>
        public int VersionMinor
        {
            get
            {
                return Package.VersionMinor;
            }
            set
            {
                Package.VersionMinor = value;
            }
        }

       
        internal Package Package
        {
            get
            {
                return _package;
            }
        }

        /// <summary>
        /// Adds the an <see cref="iConnection"/> to the package that can be used by other tasks and
        /// data flow components.
        /// </summary>
        /// <param name="id">A <c>String</c> that represents the internal name used to identify the
        /// connection whilst the package is being created.</param>
        /// <param name="connectionType">Type of the connection as represented by the
        /// <see cref="iConnection.ConnectionType"/> enumeration.</param>
        /// <param name="name">A <c>String</c> that represents the name that will be given to the
        /// connection that will be visible in the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <param name="description">A <c>String</c> that represents a description that will be given
        /// to the connection that will be visible in the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <returns>An <see cref="iConnection"/> instance that represents the connection in the
        /// <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</returns>
        public iConnection AddConnection(string id, iConnection.ConnectionType connectionType, string name, string description)
        {
            iConnection ret = new iConnection(_package, connectionType, name, description);

            _connections.Add(id, ret);

            return ret;
        }

        /// <summary>
        /// Adds an expression to the package as a variable in the default namespace.
        /// </summary>
        /// <param name="name">A <c>String</c> that represents the name of the expression that will be visible
        /// in the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <param name="description">A <c>String</c> that represents the description of the expression that
        /// will be visible in the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <param name="expression">A <c>String</c> that represents the expression to assign to the variable.</param>
        /// <returns>An <see cref="iVariable"/> that represents the expression in the container.</returns>
        public iVariable AddExpression(string name, string description, string expression)
        {
            return AddVariable(name, description, "User", expression, true);
        }

        /// <summary>
        /// Adds an expression to the package as a variable in the default namespace.
        /// </summary>
        /// <param name="name">A <c>String</c> that represents the name of the expression that will be visible
        /// in the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <param name="description">A <c>String</c> that represents the description of the expression
        /// that will be visible in the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <param name="nameSpace">A <c>String</c> that represents the namespace that the variable has been defined in.</param>
        /// <param name="expression">A <c>String</c> that represents the expression to assign to the variable.</param>
        /// <returns>An <see cref="iVariable"/> that represents the variable in the container.</returns>
        public iVariable AddExpression(string name, string description, string nameSpace, string expression)
        {
            return AddVariable(name, description, nameSpace, expression, true);
        }

        /// <summary>
        /// Adds a parameter to the package.
        /// </summary>
        /// <param name="name">A <c>String</c> that represents the name of the parameter that will be visible
        /// in the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <param name="description">A <c>String</c> that represents the description of the parameter that
        /// will be visible in the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <param name="value">The value to assign to the parameter.</param>
        /// <returns>An <see cref="iVariable"/> that represents the parameter in the container.</returns>
        public iVariable AddParameter(string name, string description, object value)
        {
            iVariable ret = null;
            Parameter parameter = _package.Parameters.Add(name, Type.GetTypeCode(value.GetType()));
            parameter.Value = value;
            parameter.Description = description;

            ret = new iVariable(parameter, value, true, false);

            _variables.Add(VariableName(name, "Package"), ret);

            return ret;
        }

        /// <summary>
        /// Adds a task to the package and returns an instance of the task.
        /// </summary>
        /// <typeparam name="T">The type of task to add to the package. The type must inherit
        /// from <see cref="iControlFlowTask"/>.</typeparam>
        /// <param name="name">A <c>String</c> that represents the name to give to the task that will be visible
        /// in the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <param name="description">A <c>String</c> that represents the description to give to the task that
        /// will be visible in the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <returns>The <see cref="iControlFlowTask"/> that represents the task in the container.</returns>
        public T AddTask<T>(string name, string description) where T : iControlFlowTask, new()
        {
            T ret = new T();
            dynamic d = ret;
            string classId = d.GetClassId();
            Executable newExec = _package.Executables.Add(classId);
            ret.Init(this, null, newExec, classId, name, description);

            return ret;
        }

        /// <summary>
        /// Adds a task to the package and returns an instance of the task. Use this method when the type of the
        ///  component you wish to add is not known until runtime.
        /// </summary>
        /// <param name="iComponentName">The type of task to add to the package. The type must inherit from
        /// <see cref="iControlFlowTask"/>.</param>
        /// <param name="name">A <c>String</c> that represents the name to give to the task that will be visible
        /// in the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <param name="description">A <c>String</c> that represents the description to give to the task that
        /// will be visible in the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <returns>The <see cref="iControlFlowTask"/> that represents the task in the container.</returns>
        public iControlFlowTask AddTask(string iComponentName, string name, string description)
        {
            iControlFlowTask ret = null;
            iComponentName = "RandomThunks.API.SSiS." + iComponentName;
            ret = (iControlFlowTask)Activator.CreateInstance(Type.GetType(iComponentName));

            string classId = ret.GetClassId();
            Executable newExec = _package.Executables.Add(classId);
            ret.Init(this, null, newExec, classId, name, description);


            return ret;
        }

        /// <summary>
        /// Adds an <see cref="iVariable"/> to the package which can either be a constant or an expression.
        /// </summary>
        /// <param name="name">A <c>string</c> that represents the variable name in the
        /// <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <param name="description">A <c>string</c> that represents the description of the variable in
        /// the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>..</param>
        /// <param name="nameSpace">A <c>string</c> that represents the variable's namespace.</param>
        /// <param name="value">The initial value to assign to the variable.</param>
        /// <param name="isExpression">If <c>true</c> then the value is treated as an expresion,
        /// otherwise it is just a constant.</param>
        /// <returns>The <see cref="iVariable"/> class that represents the variable in the
        /// <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</returns>
        public iVariable AddVariable(string name, string description, string nameSpace, object value, bool isExpression)
        {
            iVariable ret = null;
            Variable variable = _package.Variables.Add(name, false, nameSpace, value);
            variable.Description = description;
            if (isExpression)
            {
                variable.EvaluateAsExpression = true;
                variable.Expression = value.ToString();
            }

            ret = new iVariable(variable, value, isExpression);

            _variables.Add(VariableName(name, nameSpace), ret);

            return ret;
        }

        /// <summary>
        /// Adds an <see cref="iVariable"/> to the package with a constant value
        /// </summary>
        /// <param name="name">A <c>string</c> that represents the variable in the provided namespace in
        /// the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <param name="description">A <c>string</c> that represents the description of the variable in
        /// the <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</param>
        /// <param name="nameSpace">A <c>string</c> that represents the variable's namespace.</param>
        /// <param name="value">The initial value to assign to the variable.</param>
        /// <returns>The <see cref="iVariable"/> class that represents the variable in the
        /// <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</returns>
        public iVariable AddVariable(string name, string description, string nameSpace, object value)
        {
            return AddVariable(name, description, nameSpace, value, false); ;
        }

        /// <summary>
        /// Adds an <see cref="iVariable"/> to the package with a constant value in the default namespace.
        /// </summary>
        /// <param name="name">A <c>string</c> that represents the variable in the default namespace.</param>
        /// <param name="description">A <c>string</c> that represents the description of the variable.</param>
        /// <param name="value">The initial value to assign to the variable.</param>
        /// <returns>The <see cref="iVariable"/> class that represents the variable in the
        /// <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</returns>
        public iVariable AddVariable(string name, string description, object value)
        {
            return AddVariable(name, description, "User", value);
        }

        /// <summary>
        /// Checks the status of the digital signature of the package.
        /// </summary>
        /// <returns>One of the enumeration values that indicates the status of the digital signature.</returns>
        public SignatureStatus CheckSignature()
        {
            return (SignatureStatus)_package.CheckSignature();
        }

        /// <summary>
        /// Gets an <see cref="iConnection"/> identified by an internal identifier.
        /// </summary>
        /// <param name="id">A <c>String</c> that represents the connection identifier.</param>
        /// <returns>iConnection.</returns>
        public iConnection GetConnectionById(string id)
        {
            return _connections[id];
        }

        /// <summary>
        /// Gets the parameter.
        /// </summary>
        /// <param name="name">A <c>String</c> that represents the name of the parameter.</param>
        /// <returns>The <see cref="iVariable"/> class that represents the parameter in the
        /// <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</returns>
        public iVariable GetParameter(string name)
        {
            return _variables[string.Format("Package:{0}", name)];
        }

        /// <summary>
        /// Returns a previously defined <see cref="iVariable"/> in the default user namespace
        /// </summary>
        /// <param name="name">A <c>String</c> that represents the variable name in the default namesdpace.</param>
        /// <returns>The <see cref="iVariable"/> class that represents the variable in the
        /// <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</returns>
        public iVariable GetVariable(string name)
        {
            return GetVariable(name, "User");
        }

        /// <summary>
        /// Returns a previously defined <see cref="iVariable"/> in a named namespace
        /// </summary>
        /// <param name="name">A <c>String</c> that represents the variable name in the provided namespace.</param>
        /// <param name="nameSpace">A <c>String</c> that represents the name of the namespace.</param>
        /// <returns>The <see cref="iVariable"/> class that represents the variable in the
        /// <see cref="Microsoft.SqlServer.Dts.Runtime.DtsContainer"/>.</returns>
        public iVariable GetVariable(string name, string nameSpace)
        {
            return _variables[VariableName(name, nameSpace)];
        }

        /// <summary>
        /// Persists the package to disk.
        /// </summary>
        /// <returns><c>true</c> if the save completed successfuly, otherwise <c>false</c>.</returns>
        public bool Save()
        {
            bool ret = false;

            _package.ComputeExpressions(true);
            _application.SaveToXml(_path, _package, null);

            ret = true;

            return ret;
        }
        /// <summary>
        /// Returns a fully qualified variable name
        /// </summary>
        /// <param name="name">A <c>String</c> that represents the variable name in the provided namespace.</param>
        /// <param name="nameSpace">A <c>String</c> that represents the name of the namespace.</param>
        /// <returns>a <c>String</c> that contains the fully qualified variable name.</returns>
        private string VariableName(string name, string nameSpace)
        {
            return string.Format("{0}:{1}", nameSpace, name);
        }
    }
}
