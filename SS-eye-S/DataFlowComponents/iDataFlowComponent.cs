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
using System.Text;
using Microsoft.SqlServer.Dts.Pipeline.Wrapper;
using Microsoft.SqlServer.Dts.Runtime;

namespace RandomThunks.API.SSiS
{
    /// <Summary>
    /// Specifies the objects that implement the Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSObject100
    /// interface in the data flow object model.
    /// </Summary>
    public enum FlowComponentType
    {
        /// <Summary>
        /// Specifies that the object type was unknown to the data flow engine.
        OT_UNSPECIFIED = 0,
        /// <Summary>
        /// Specifies that an object is a source component that has one or more Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSOutput100
        /// objects and zero Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSInput100 objects.
        /// </Summary>
        OT_SOURCEADAPTER = 1,       
        /// <Summary>
        /// Specifies that an object is a destination component having one or more Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSInput100
        /// objects and zero Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSOutput100 objects.
        /// </Summary>
        OT_DESTINATIONADAPTER = 2,
        /// <Summary>
        /// Specifies that an object is a transform component that has one or more Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSOutput100
        /// objects and one or more Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSInput100 objects.
        /// </Summary>
        OT_TRANSFORM = 4,
        /// <Summary>
        /// Specifies an object as a data flow component that implements the Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSDesigntimeComponent100
        /// and Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSRuntimeComponent100 interfaces.
        /// </Summary>
        OT_COMPONENT = 8,
        /// <Summary>
        /// Specifies that an object is an Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSComponentView100 object.
        /// </Summary>
        OT_COMPONENTVIEWER = 16,
        /// <Summary>
        /// Specifies that an object is an Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSPath100 object.
        /// </Summary>
        OT_PATH = 32,
        /// <Summary>
        /// Specifies that an object is an Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSInput100 object.
        /// </Summary>
        OT_INPUT = 64,
        /// <Summary>
        /// Specifies that an object is an Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSVirtualInput100 object.
        /// </Summary>
        OT_VIRTUALINPUT = 128,
        /// <Summary>
        /// Specifies that an object is an Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSOutput100 object.
        /// </Summary>
        OT_OUTPUT = 256,
        /// <Summary>
        /// Specifies that an object is an Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSInputColumn100 object.
        /// </Summary>
        OT_INPUTCOLUMN = 512,
        /// <Summary>
        /// Specifies that an object is an Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSOutputColumn100 object.
        /// </Summary>
        OT_OUTPUTCOLUMN = 1024,
        /// <Summary>
        /// Specifies that an object is an Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSVirtualInputColumn100 object.
        /// </Summary>
        OT_VIRTUALINPUTCOLUMN = 2048,
        /// <Summary>
        /// Specifies that an object is an Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSCustomProperty100 object.
        /// </Summary>
        OT_PROPERTY = 4096,
        /// <Summary>
        /// Specifies that an object is an Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSRuntimeConnection100 object.
        /// </Summary>
        OT_RUNTIMECONNECTION = 8192,
        /// <Summary>
        /// Specifies that an object is an Microsoft.SqlServer.Dts.Pipeline.Wrapper.IDTSExternalMetadataColumn100 object.
        /// </Summary>
        OT_EXTERNALMETADATACOLUMN = 16384,
    }

    /// Summary>
    /// Indicates the data type of columns in data flow components and the data flow buffer.
    /// </Summary>
    public enum ColumnDataType
    {
        /// <Summary>
        /// A data type that does not have a value. The numeric value is 0.
        /// </Summary>
        DT_EMPTY = 0,
        /// <Summary>
        /// A data type with a value of NULL. The numeric value is 1.
        /// </Summary>
        DT_NULL = 1,
        /// <Summary>
        /// A 2-byte, signed integer. The numeric value is 2.
        /// </Summary>
        DT_I2 = 2,
        /// <Summary>
        /// A 4-byte, signed integer. The numeric value is 3.
        /// </Summary>
        DT_I4 = 3,
        /// <Summary>
        /// A single-precision floating-point value. The numeric value is 4.
        /// </Summary>
        DT_R4 = 4,
        /// <Summary>
        /// A double-precision floating-point value. The numeric value is 5.
        /// </Summary>
        DT_R8 = 5,
        /// <Summary>
        /// A currency value. This data type is an 8-byte value with a scale of 4 and
        /// a maximum precision of 19. The numeric value is 6.
        /// </Summary>
        DT_CY = 6,
        /// <Summary>
        /// A date structure that consists of year, month, day, and hour.
        /// </Summary>
        DT_DATE = 7,
        /// <Summary>
        /// A Boolean value. The numeric value is 11.
        /// </Summary>
        DT_BOOL = 11,
        /// <Summary>
        /// An exact numeric value with a fixed precision and a fixed scale. This data type is a 12-byte value with
        /// a separate sign, a scale of 0 to 28, and a maximum precision of 29. The numeric value is 14.
        /// </Summary>
        DT_DECIMAL = 14,
        /// <Summary>
        /// A 1-byte, signed integer. The numeric value is 16.
        /// </Summary>
        DT_I1 = 16,
        /// <Summary>
        /// A 1-byte, unsigned integer. The numeric value is 17.
        /// </Summary>
        DT_UI1 = 17,
        /// <Summary>
        /// A 2-byte, unsigned integer. The numeric value is 18.
        /// </Summary>
        DT_UI2 = 18,
        /// <Summary>
        /// A 4-byte, unsigned integer. The numeric value is 19.
        /// </Summary>
        DT_UI4 = 19,
        /// <Summary>
        /// An 8-byte, signed integer. The numeric value is 20.
        /// </Summary>
        DT_I8 = 20,
        /// <Summary>
        /// An 8-byte, unsigned integer. The numeric value is 21.
        /// </Summary>
        DT_UI8 = 21,
        /// <Summary>
        /// A 64-bit value that represents the number of 100-nanosecond intervals since January 1, 1601. The numeric value is 64.
        /// </Summary>
        DT_FILETIME = 64,
        /// <Summary>
        /// A globally unique identifier (GUID). The numeric value is 72.
        /// </Summary>
        DT_GUID = 72,
        /// <Summary>
        /// A binary data value. The length is variable and the maximum length is 8,000 bytes. The numeric value is 128.
        /// </Summary>
        DT_BYTES = 128,
        /// <Summary>
        /// A null-terminated ANSI/MBCS character string. The numeric value is 129.
        /// </Summary>
        DT_STR = 129,
        /// <Summary>
        /// A null-terminated Unicode character string. The numeric value is 130.
        /// </Summary>
        DT_WSTR = 130,
        /// <Summary>
        /// An exact numeric value with a fixed precision and scale. This data type is a 16-byte value with a separate sign,
        /// a scale of 0 to 38, and a maximum precision of 38. The numeric value is 131.
        /// </Summary>
        DT_NUMERIC = 131,
        /// <Summary>
        /// A date structure that consists of year, month, and date. The numeric value is 133.
        /// </Summary>
        DT_DBDATE = 133,
        /// <Summary>
        /// A time structure that consists of hour, minute, and second. The numeric value is 134.
        /// </Summary>
        DT_DBTIME = 134,
        /// <Summary>
        /// A timestamp structure that consists of year, month, day, hour, minute, second, and fractional seconds.
        /// The fractional seconds have a maximum scale of 3 digits. The numeric value is 135.
        /// </Summary>
        DT_DBTIMESTAMP = 135,
        /// <Summary>
        /// A time structure that consists of hour, minute, second, and fractional seconds. The fractional seconds
        /// have a maximum scale of 7 digits. The numeric value is 145.
        /// </Summary>
        DT_DBTIME2 = 145,
        /// <Summary>
        /// A timestamp structure that consists of year, month, day, hour, minute, second, and fractional seconds.
        /// The fractional seconds have a maximum scale of 7 digits.
        /// </Summary>
        DT_DBTIMESTAMPOFFSET = 146,
        /// <Summary>
        /// A binary value with a maximum size of 231–1 (2,147,483,647) bytes. The numeric value is 301.
        /// </Summary>
        DT_IMAGE = 301,
        /// <Summary>
        /// An ANSI/MBCS character string with a maximum length of 231–1 (2,147,483,647) characters. The numeric
        /// value is 302.
        /// </Summary>
        DT_TEXT = 302,
        /// <Summary>
        /// A Unicode character string with a maximum length of 2^30–1 (1,073,741,823) characters. The numeric
        /// value is 303.
        /// </Summary>
        DT_NTEXT = 303,
        /// <Summary>
        /// A timestamp structure that consists of year, month, day, hour, minute, second, and fractional seconds.
        /// The fractional seconds have a maximum scale of 7 digits. The numeric value is 304.
        /// </Summary>
        DT_DBTIMESTAMP2 = 304,
        /// <Summary>
        /// A pointer to a 2-byte, signed integer. The numeric value is 16386.
        /// </Summary>
        DT_BYREF_I2 = 16386,
        /// <Summary>
        /// A pointer to a 4-byte, signed integer. The numeric value is 16387.
        /// </Summary>
        DT_BYREF_I4 = 16387,
        /// <Summary>
        /// A pointer to a single-precision floating-point value. The numeric value is 16388.
        /// </Summary>
        DT_BYREF_R4 = 16388,
        /// <Summary>
        /// A pointer to a double-precision floating-point value. The numeric value is 16389.
        /// </Summary>
        DT_BYREF_R8 = 16389,
        /// <Summary>
        /// A pointer to a currency value. This data type is an 8-byte value with a scale of 4 and a maximum
        /// precision of 19. The numeric value is 16390.
        /// </Summary>
        DT_BYREF_CY = 16390,
        /// <Summary>
        /// A pointer to a date structure that consists of year, month, date, and hour. The numeric value is 16391.
        /// </Summary>
        DT_BYREF_DATE = 16391,
        /// <Summary>
        /// A pointer to a Boolean value. The numeric value is 16395.
        /// </Summary>
        DT_BYREF_BOOL = 16395,
        /// <Summary>
        /// A pointer to an exact numeric value with a fixed precision and a fixed scale. This data type is a
        /// 12-byte value with a separate sign, a scale of 0 to 28, and a maximum precision of 29. The numeric
        /// value is 16398.
        /// </Summary>
        DT_BYREF_DECIMAL = 16398,
        /// <Summary>
        /// A pointer to a 1-byte, signed integer. The numeric value is 16400.
        /// </Summary>
        DT_BYREF_I1 = 16400,
        /// <Summary>
        /// A pointer to a 1-byte, unsigned integer. The numeric value is 16401.
        /// </Summary>
        DT_BYREF_UI1 = 16401,
        /// <Summary>
        /// A pointer to a 2-byte, unsigned integer. The numeric value is 16402.
        /// </Summary>
        DT_BYREF_UI2 = 16402,
        /// <Summary>
        /// A pointer to a 4-byte, unsigned integer. The numeric value is 16403.
        /// </Summary>
        DT_BYREF_UI4 = 16403,
        /// <Summary>
        /// A pointer to an 8-byte, signed integer. The numeric value is 16404.
        /// </Summary>
        DT_BYREF_I8 = 16404,
        /// <Summary>
        /// A pointer to an 8-byte, unsigned integer. The numeric value is 16405.
        /// </Summary>
        DT_BYREF_UI8 = 16405,
        /// <Summary>
        /// A pointer to a 64-bit value that represents the number of 100-nanosecond intervals since January 1, 1601.
        /// The numeric value is 16448.
        /// </Summary>
        DT_BYREF_FILETIME = 16448,
        /// <Summary>
        /// A pointer to a GUID. The numeric value is 16456.
        /// </Summary>
        DT_BYREF_GUID = 16456,
        /// <Summary>
        /// A pointer to an exact numeric value with a fixed precision and scale. This data type is a 16-byte value
        /// with a separate sign, a scale of 0 to 38, and a maximum precision of 38. The numeric value is 16515.
        /// </Summary>
        DT_BYREF_NUMERIC = 16515,
        /// <Summary>
        /// A pointer to a date structure that consists of year, month, and date. The numeric value is 16517.
        /// </Summary>
        DT_BYREF_DBDATE = 16517,
        /// <Summary>
        /// A pointer to a time structure that consists of hour, minute, and second. The numeric value is 16518.
        /// </Summary>
        DT_BYREF_DBTIME = 16518,
        /// <Summary>
        /// A pointer to a timestamp structure that consists of year, month, day, hour, minute, second, and
        /// fractional seconds. The fractional seconds have a maximum scale of 3 digits. The numeric value is 16519.
        /// </Summary>
        DT_BYREF_DBTIMESTAMP = 16519,
        /// <Summary>
        /// A pointer to a time structure that consists of hour, minute, second, and fractional seconds. The
        /// fractional seconds have a maximum scale of 7 digits. The numeric value is 16520.
        /// </Summary>
        DT_BYREF_DBTIME2 = 16520,
        /// <Summary>
        /// A pointer to a timestamp structure that consists of year, month, day, hour, minute, second, and
        /// fractional seconds. The fractional seconds have a maximum scale of 7 digits. The numeric value is 16521.
        /// </Summary>
        DT_BYREF_DBTIMESTAMPOFFSET = 16521,
        /// <Summary>
        /// A pointer to a timestamp structure that consists of year, month, day, hour, minute, second, and
        /// fractional seconds. The fractional seconds have a maximum scale of 7 digits. The numeric value is 16522.
        /// </Summary>
        DT_BYREF_DBTIMESTAMP2 = 16522,
    }
    public class iDataFlowPath
    {
        IDTSPath100 _path;

        internal iDataFlowPath(IDTSPath100 path)
        {
            _path = path;
        }

        internal string Name
        {
            get
            {
                return _path.Name;
            }
            set
            {
                _path.Name = value;
            }
        }

        internal string Description
        {
            get
            {
                return _path.Description;
            }
            set
            {
                _path.Description = value;
            }
        }

        public int Id
        {
            set
            {
                _path.ID = value;
            }
            get
            {
                return _path.ID;
            }
        }
    }
    public abstract class iDataFlowComponent
    {

        [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
        public sealed class DataFlowTypeAttribute : Attribute
        {
            private string _id;
            public DataFlowTypeAttribute(string id)
            {
                _id = id;
            }
            public string ID { get { return _id; } }
        }

        public enum ComponentState { OK, Failed };

        private IDTSComponentMetaData100 _component;
        private CManagedComponentWrapper _wrapper;
        private iDataFlow _dataFlowTask;
        private ComponentState _state;
        private Exception _lastException;

        internal string GetClassId()
        {
            string ret = string.Empty;
            Attribute[] attributes = Attribute.GetCustomAttributes(GetType());
            foreach (var attribute in attributes)
                if (attribute is DataFlowTypeAttribute)
                {
                    ret = (attribute as DataFlowTypeAttribute).ID;
                    break;
                }

            return ret;
        }
        internal iDataFlow Task
        {
            get
            {
                return _dataFlowTask;
            }
        }
        public string Name
        {
            get
            {
                return _component.Name;
            }
        }

        public string Description
        {
            get
            {
                return _component.Description;
            }
        }
        public enum ComponentType
        {
            DTSTransform_Merge,
            DTSTransform_MergeJoin,
            DTSTransform_Lookup,
            DTSTransform_Lineage,
            DTSTransform_RowSampling,
            MSMDPP_PXPipelineProcessDimension,
            DTSTransform_TermExtraction,
            MSMDPP_PXPipelineProcessDM,
            DTSAdapter_OLEDBSource,
            DTSTransform_CharacterMap,
            DTSTransform_GroupDups,
            DTSTransform_PctSampling,
            DTSAdapter_ExcelDestination,
            DTSTransform_Pivot,
            MSMDPP_PXPipelineDMQuery,
            DTSAdapter_SQLServerDestination,
            DTSTransform_ConditionalSplit,
            DTSTransform_SCD,
            DTSAdapter_FlatFileSource,
            DTSTransform_TermLookup,
            DTSTransform_CopyMap,
            DTSTransform_DerivedColumn,
            DTSTransform_BestMatch,
            DTSAdapter_FlatFileDestination,
            MSMDPP_PXPipelineProcessPartition,
            TxFileInserter_Inserter,
            DTSAdapter_ExcelSource,
            DTSTransform_DataConvert,
            DTSTransform_UnionAll,
            DTSTransform_OLEDBCommand,
            DTSTransform_UnPivot,
            TxFileExtractor_Extractor,
            DTSTransform_RowCount,
            DTSAdapter_OLEDBDestination,
            DTSAdapter_RawSource,
            DTSAdapter_RawDestination,
            DTSTransform_Multicast,
            DTSTransform_Sort,
            DTSTransform_Aggregate,
            DTSAdapter_RecordsetDestination,
            ADONETDataSource
        }

        public iDataFlowComponent()
        {
        }

        internal void Init(iDataFlow task, IDTSComponentMetaData100 component, string classId, string name, string description)
        {
            _state = ComponentState.Failed;
            _lastException = null;
            try
            {
                _component = component;
                _dataFlowTask = task;

                _component.ComponentClassID = classId;
                _wrapper = _component.Instantiate();
                _wrapper.ProvideComponentProperties();
                
                
                _component.Name = name;
                _component.Description = description;

                _state = ComponentState.OK;
            }
            catch (Exception e)
            {
                _lastException = e;
            }
        }

        //protected internal iDataFlowComponent(MainPipe dataFlow, ComponentType type, string name, string description)
        //    : this(dataFlow, type.ToString().Replace("_", "."), name, description)
        //{

        //}

        internal iDataFlow Parent
        { 
            get
            {
                return _dataFlowTask;
            }
        }
        public IDTSComponentMetaData100 Component
        {
            get
            {
                return _component; ;
            }
        }

        public CManagedComponentWrapper Wrapper
        {
            get
            {
                return _wrapper; ;
            }
        }

        public ComponentState State
        {
            get
            {
                return _state;
            }
        }

        public Exception LastException
        {
            get
            {
                return _lastException;
            }
        }

        public bool RefreshMetadata()
        {
            bool ret = false;
            if (_state == iDataFlowComponent.ComponentState.OK && _wrapper != null)
                try
                {
                    if (_component.RuntimeConnectionCollection.Count > 0)
                        _wrapper.AcquireConnections(null);
                    _wrapper.ReinitializeMetaData();
                    if (_component.RuntimeConnectionCollection.Count > 0)
                        _wrapper.ReleaseConnections();

                    ret = true;
                }
                catch (Exception e)
                {
                    if (e.HResult == -1071636390) // 0xC020205A
                        throw new ArgumentNullException("Raw filename has not been defined.");
                    if (e.HResult == -1071636368) //  0xC0202070
                        throw new ArgumentOutOfRangeException("The file name property is not valid. The file name is a device or contains invalid characters.");
                        _lastException = e;
                }

            return ret;
        }

        public iDataFlowPath ConnectTo(iDataFlowComponent destination)
        {
            IDTSPath100 path = null;
            if (_state == ComponentState.OK && destination != null && destination.State == ComponentState.OK)
                try
                {
                    path = _dataFlowTask.Me.PathCollection.New();
                    path.AttachPathAndPropagateNotifications(_component.OutputCollection[0], destination.Component.InputCollection[0]);
                    path.Name = "Output from " + _component.Name;
                    path.Description = string.Format("Output from {0} to {1}", _component.Name, destination.Component.Name);

                    MapColumns();
                }
                catch (Exception e)
                {
                    _lastException = e;
                }

            return new iDataFlowPath(path);
        }

        public iDataFlowPath SetPredessor(iDataFlowComponent source)
        {
            IDTSPath100 path = null;
            if (_state == ComponentState.OK && source != null && source.State == ComponentState.OK)
                try
                {
                    path = _dataFlowTask.Me.PathCollection.New();
                    path.Name = "Output from " + source.Component.Name;
                    path.Description = string.Format("Output from {0} to {1}", source.Component.Name, _component.Name);
                    path.AttachPathAndPropagateNotifications(source.Component.OutputCollection[0], Component.InputCollection[0]);
                    
                    if (this.Mapable)
                        MapColumns();

                    RefreshMetadata();
                }
                catch (Exception e)
                {
                    _lastException = e;
                }

            
            return new iDataFlowPath(path);
        }

        public bool MapColumns()
        {
            bool ret = false;

            try
            {
                IDTSInput100 input = _component.InputCollection[0];
                IDTSVirtualInput100 vInput = input.GetVirtualInput();
                SortedList<string, IDTSVirtualInputColumn100> inputColumns = new SortedList<string, IDTSVirtualInputColumn100>();
                foreach (IDTSVirtualInputColumn100 virtualInputColumn in vInput.VirtualInputColumnCollection)
                {
                    if (inputColumns.ContainsKey(virtualInputColumn.Name))
                        inputColumns.Remove(virtualInputColumn.Name);
                    inputColumns.Add(virtualInputColumn.Name, virtualInputColumn);
                }
                foreach (IDTSVirtualInputColumn100 virtualInputColumn in inputColumns.Values)
                {
                    IDTSInputColumn100 realInputColumn = _wrapper.SetUsageType(input.ID, vInput, virtualInputColumn.LineageID, DTSUsageType.UT_READONLY);
                    if (HasExternalColumns)
                    {
                        // Find external column by name
                        try
                        {
                            IDTSExternalMetadataColumn100 myRealColumn = input.ExternalMetadataColumnCollection[realInputColumn.Name];
                            // Map input column to external column
                            _wrapper.MapInputColumn(input.ID, realInputColumn.ID, myRealColumn.ID);
                        }
                        catch
                        {
                        }
                    }
                    ret = true;
                }
            }
            catch (Exception e)
            {
                _lastException = e;
            }

            return ret;
        }

        internal bool SetProperty(string propertyName, object value)
        {
            bool ret = false;
            if (_state == ComponentState.OK && _wrapper != null)
                try
                {
                    _wrapper.SetComponentProperty(propertyName, value);
                    ret = true;
                }
                catch (Exception e)
                {
                    _lastException = e;
                }

            return ret;
        }

        internal object GetProperty(string propertyName)
        {
            object ret = null;
            if (_state == ComponentState.OK && _wrapper != null)
                try
                {
                    //TODO: Fetch a property here
                    ret = null;
                }
                catch (Exception e)
                {
                    _lastException = e;
                }

            return ret;
        }

        public bool UpdateColumnMetaData(string columnName, ColumnDataType dataType, int length, int precision, int scale, int codePage)
        {
            bool ret = false;

            
            if (_state == ComponentState.OK && _component != null)
                try
                {
                    IDTSOutput100 columns = _component.OutputCollection[0];
                    foreach (IDTSOutputColumn100 column in columns.OutputColumnCollection)
                    {
                        if (column.Name == columnName)
                        {
                            column.SetDataTypeProperties((Microsoft.SqlServer.Dts.Runtime.Wrapper.DataType)dataType, length, precision, scale, codePage);
                        }
                    }
                }
                catch (Exception e)
                {
                    _lastException = e;
                }

            return ret;
        }

        public bool UpdateColumnDescription(string columnName, string description)
        {
            bool ret = false;

            if (_state == ComponentState.OK && _component != null)
                try
                {
                    IDTSOutput100 columns = _component.OutputCollection[0];
                    foreach (IDTSOutputColumn100 column in columns.OutputColumnCollection)
                    {
                        if (column.Name == columnName)
                        {
                            column.Description = description;
                        }
                    }
                }
                catch (Exception e)
                {
                    _lastException = e;
                }

            return ret;
        }
        public bool IgnoreAllTruncations()
        {
            bool ret = false;

            if (_state == ComponentState.OK && _component != null)
                try
                {
                    IDTSOutput100 columns = _component.OutputCollection[0];
                    foreach (IDTSOutputColumn100 column in columns.OutputColumnCollection)
                    {
                        if (column.DataType == Microsoft.SqlServer.Dts.Runtime.Wrapper.DataType.DT_STR || column.DataType == Microsoft.SqlServer.Dts.Runtime.Wrapper.DataType.DT_WSTR)
                            column.TruncationRowDisposition = DTSRowDisposition.RD_IgnoreFailure;
                    }

                    ret = true;
                }
                catch (Exception e)
                {
                    _lastException = e;
                }

            return ret;
        }

        internal virtual bool Mapable
        {
            get { return true; }
        }

        internal virtual bool HasExternalColumns
        {
            get { return false; }
        }

        public void SetExpression(string propertyName, string expression)
        {
            Parent.SetExpression(string.Format("[{0}].[{1}]", Name, propertyName), expression);
        }

        public void SetExpression(string propertyName, iVariable variable)
        {
            Parent.SetExpression(string.Format("[{0}].[{1}]", Name, propertyName), variable.ToString());
        }
    }
}