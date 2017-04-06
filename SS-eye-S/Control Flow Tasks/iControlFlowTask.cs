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
using Microsoft.SqlServer.Dts.Tasks.ExpressionTask;
using Microsoft.SqlServer.Dts.Tasks.ExecuteSQLTask;
using System.Reflection;

namespace RandomThunks.API.SSiS
{

    // Summary:
    //     Provides values that describe the result of a task execution.
    public enum iExecResult
    {
        /// <summary>
        /// The task ran successfully. (Value = 0)
        /// </summary>
        Success = 0,
        /// <summary>
        /// The task failed. (Value = 1)
        /// </summary>
        Failure = 1,
        /// <summary>
        /// The task ran to completion. (Value = 2)
        /// </summary>
        Completion = 2,
        /// <summary>
        /// The task was canceled. (Value = 3)
        /// </summary>
        Canceled = 3,
    }

    // Summary:
    //     Indicates the evaluation operations that the precedence constraint uses.
    public enum iPrecedenceEvalOp
    {
        /// <summary>
        /// Specifies that the value of an expression determines whether the constrained
        /// container or task runs. Set the Microsoft.SqlServer.Dts.Runtime.PrecedenceConstraint.Expression
        /// property of the Microsoft.SqlServer.Dts.Runtime.PrecedenceConstraint.
        /// </summary>
        Expression = 1,
        /// <summary>
        /// Specifies that the execution outcome determines whether the constrained container
        /// or task runs. Set the Microsoft.SqlServer.Dts.Runtime.PrecedenceConstraint.Value
        /// property of the Microsoft.SqlServer.Dts.Runtime.PrecedenceConstraint to the
        /// desired value from the Microsoft.SqlServer.Dts.Runtime.DTSExecResult enumeration.
        /// </summary>
        Constraint = 2,
        /// <summary>
        ///     Specifies that the constraint outcome must occur and the expression must
        ///     evaluate for the constrained container or task to run. Set both the Microsoft.SqlServer.Dts.Runtime.PrecedenceConstraint.Value
        ///     and the Microsoft.SqlServer.Dts.Runtime.PrecedenceConstraint.Expression properties
        ///     of the Microsoft.SqlServer.Dts.Runtime.PrecedenceConstraint, and set its
        ///     Microsoft.SqlServer.Dts.Runtime.PrecedenceConstraint.LogicalAnd property
        ///     to true.
        /// </summary>
        ExpressionAndConstraint = 3,
        /// <summary>
        ///     Specifies that either the constraint outcome must occur, or the expression
        ///     must evaluate, for the constrained container or task to run. Set both the
        ///     Microsoft.SqlServer.Dts.Runtime.PrecedenceConstraint.Value and the Microsoft.SqlServer.Dts.Runtime.PrecedenceConstraint.Expression
        ///     properties of the Microsoft.SqlServer.Dts.Runtime.PrecedenceConstraint, and
        ///     set its Microsoft.SqlServer.Dts.Runtime.PrecedenceConstraint.LogicalAnd property
        ///     to false.
        /// </summary>
        ExpressionOrConstraint = 4,
    }
    public interface IControlFlowTask : IContainer
    {
   
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class ClassIdAttribute : Attribute
    {
        private string _id;
        public ClassIdAttribute(string id)
        {
            _id = id;
        }
        public string ID { get { return _id; } }
    }

    public abstract class iControlFlowTask : IControlFlowTask
    {
        public enum ThisTaskType
        {
            ActiveXScriptTask,
            BulkInsertTask,
            ExecuteProcessTask,
            ExecutePackageTask,
            Exec80PackageTask,
            ExpressionTask,
            FileSystemTask,
            FTPTask,
            MSMQTask,
            PipelineTask,
            ScriptTask,
            SendMailTask,
            SQLTask,
            TransferStoredProceduresTask,
            TransferLoginsTask,
            TransferErrorMessagesTask,
            TransferJobsTask,
            TransferObjectsTask,
            TransferDatabaseTask,
            WebServiceTask,
            WmiDataReaderTask,
            WmiEventWatcherTask,
            XMLTask,
            Sequence,
            ForLoop,
            ForEachLoop

        }

        SortedList<string, iVariable> _variables;

        private IDTSSequence _parent;
        private IDTSSequence _me;
        private Executable _executable;
        private object _raw;
        private bool _isContainer;
        private string _taskId;
        private iPackage _package;
        private TaskHost _taskHost;

        internal iControlFlowTask() { }

        private iControlFlowTask(iPackage package, IDTSSequence parent, Executable exectable, string taskType, string name, string description)
        {
            Init(package, parent, exectable, taskType, name, description);
        }

        /// <summary>
        /// Build a new ControlFlowTask
        /// </summary>
        /// <param name="package">The iPackage class that contains the current application</param>
        /// <param name="parent">The parent ControlFlowTask that contains this task</param>
        /// <param name="executable">The Executable associated with this taskId</param>
        /// <param name="taskType">The string moniker that Identifies this task type</param>
        /// <param name="name">The name of the task</param>
        /// <param name="description">A description of the taskId</param>
        internal void Init(iPackage package, IDTSSequence parent, Executable executable, string taskType, string name, string description)
        {
            _executable = executable;
            _taskHost = (executable as TaskHost);

            _parent = parent;
            EventsProvider container = executable as EventsProvider;
            
            if (container != null)
            {
                container.Name = name;
                container.Description = description;
            }
            _taskId = taskType;

            _variables = new SortedList<string, iVariable>();

            _package = package;
        }
        internal string GetClassId()
        {
            string ret = string.Empty;
            Attribute[] attributes = Attribute.GetCustomAttributes(GetType());
            foreach (var attribute in attributes)
                if (attribute is ClassIdAttribute)
                {
                    ret = (attribute as ClassIdAttribute).ID;
                    break;
                }

            return ret;
        }
        private object GetParent()
        {
            if (_parent == null)
                return Package.Package;
            else
                return _parent;
        }

        public bool Disabled
        {
            get
            {
                return _taskHost.Disable;
            }
            set
            {
                _taskHost.Disable = true;
            }
        }
        public iPackage Package
        {
            get
            {
                return _package;
            }
        }
        public Executable Executable
        {
            get
            {
                return _executable;
            }
        }

        public TaskHost TaskHost
        {
            get
            {
                return _taskHost;
            }
        }

        
        public bool IsContainer
        {
            get
            {
                return _isContainer;
            }
            internal set
            {
                _isContainer = value;
            }
        }

        public string TaskId
        {
            get
            {
                return _taskId;
            }
        }

        public string Name
        {
            get
            {
                return (_executable as dynamic).Name;
            }
        }

        public int MaximumErrorCount
        {
            get
            {
                dynamic me = Executable;
                return me.MaximumErrorCount;
            }
            set
            {
                dynamic me = Executable;
                me.MaximumErrorCount = value;
            }

        }
        public iVariable AddVariable(string name, string description, string nameSpace, object value, bool isExpression)
        {
            iVariable ret = null;
            Variable variable = (_executable as EventsProvider).Variables.Add(name, false, nameSpace, value);
            variable.Description = description;
            if (isExpression)
            {
                variable.EvaluateAsExpression = true;
                variable.Expression = value.ToString();
            }

            ret = new iVariable(variable, value, isExpression);

            _variables.Add(string.Format("{0}.{1}", name, nameSpace), ret);

            return ret;
        }
        public iVariable AddVariable(string name, string description, string nameSpace, object value)
        {
            return AddVariable(name, description, nameSpace, value, false);
        }

        public iVariable AddVariable(string name, string description, object value)
        {
            return AddVariable(name, description, "User", value);
        }

        public iVariable AddExpression(string name, string description, string expression)
        {
            return AddVariable(name, description, "User", expression, true);
        }

        public iVariable AddExpression(string name, string description, string nameSpace, string expression)
        {
            return AddVariable(name, description, nameSpace, expression, true);
        }

        public iPrecedenceConstraint FailTaskFrom(iControlFlowTask sourceTask)
        {
            return JoinTaskFrom(sourceTask, iExecResult.Failure);
        }
        public iPrecedenceConstraint JoinTaskFrom(iControlFlowTask sourceTask)
        {
            return JoinTaskFrom(sourceTask, iExecResult.Success, iPrecedenceEvalOp.Constraint, string.Empty);
        }
        public iPrecedenceConstraint JoinTaskFrom(iControlFlowTask sourceTask, iExecResult constraint)
        {
            return JoinTaskFrom(sourceTask, constraint, iPrecedenceEvalOp.ExpressionAndConstraint, string.Empty);
        }
        public iPrecedenceConstraint JoinTaskFrom(iControlFlowTask sourceTask, string expression)
        {
            return JoinTaskFrom(sourceTask, iExecResult.Success, iPrecedenceEvalOp.ExpressionAndConstraint, expression);
        }
        public iPrecedenceConstraint JoinTaskFrom(iControlFlowTask sourceTask, iExecResult constraint, iPrecedenceEvalOp op, string expression)
        {
            return sourceTask.JoinTaskTo(this, constraint, op, expression);
        }
        public iPrecedenceConstraint JoinTaskTo(iControlFlowTask destinationTask, iExecResult constraint, iPrecedenceEvalOp op, string expression)
        {
            dynamic parent = GetParent();
            iPrecedenceConstraint ret = null;
            // 80131500
            try
            {
                ret = new iPrecedenceConstraint(parent.PrecedenceConstraints.Add(Executable, destinationTask.Executable));
                ret.PrecedenceConstraint.EvalOp = (DTSPrecedenceEvalOp)op;
                ret.PrecedenceConstraint.Value = (DTSExecResult)constraint;
                if (expression != string.Empty)
                    ret.PrecedenceConstraint.Expression = expression;
            
            }
            catch(Exception e)
            {
                if (e.HResult == -2146233088) // 80131500
                {
                    throw new ArgumentOutOfRangeException("Duplicate connections between components are not allowed.");
                }
            }
            
            return ret;
        }

        public iPrecedenceConstraint JoinTaskTo(iControlFlowTask destinationTask, string expression)
        {
            return JoinTaskTo(destinationTask, iExecResult.Success, iPrecedenceEvalOp.ExpressionAndConstraint, expression);
        }

        public iPrecedenceConstraint JoinTaskTo(iControlFlowTask destinationTask, iExecResult constraint)
        {
            return JoinTaskTo(destinationTask, constraint, iPrecedenceEvalOp.Constraint, string.Empty);
        }
        public iPrecedenceConstraint JoinTaskTo(iControlFlowTask destinationTask)
        {
            return JoinTaskTo(destinationTask, iExecResult.Success);
        }

        public iPrecedenceConstraint FailTaskTo(iControlFlowTask destinationTask)
        {
            return JoinTaskTo(destinationTask, iExecResult.Failure);
        }

        public T AddTask<T>(string name, string description) where T: iControlFlowTask, new()
        {
            T ret = new T();
            Executable newExec = null;
            if (_isContainer)
            {
                string classId = ret.GetClassId();
                newExec = (_executable as IDTSSequence).Executables.Add(classId);
                ret.Init(this.Package, this.Executable as IDTSSequence, newExec, classId, name, description);
                
            }

            return ret;
        }

        public iControlFlowTask AddTask(string iComponentName, string name, string description)
        {
            iControlFlowTask ret = null;
            Executable newExec = null;
            if (_isContainer)
            {
                ret = (iControlFlowTask)Activator.CreateInstance(Type.GetType(iComponentName));
                dynamic retD = ret;
                string classId = retD.GetClassId();
                newExec = (_executable as IDTSSequence).Executables.Add(classId);
                retD.Init(this.Package, this.Executable as IDTSSequence, newExec, classId, name, description);
            }

            return ret;
        }

        //public static iVariable AddVariable(Package package, string name, string description, string nameSpace, object value, bool isExpression)
        //{
        //    iVariable ret = null;
        //    Variable variable = package.Variables.Add(name, false,  nameSpace, value);
        //    if (isExpression)
        //    {
        //        variable.Expression = value.ToString();
        //        variable.EvaluateAsExpression = true;
        //    }

        //    variable.Description = description;

        //    ret = new iVariable(variable, value, true);

        //    return ret;
        //}
        
        //public static iVariable AddVariable(Package package, string name, string description, object value)
        //{
        //    return AddVariable(package, name, description, "User", value, false);
        //}

        //public static iVariable AddExpression(Package package, string name, string description, string value)
        //{
        //    return AddVariable(package, name, description, "User", value, true);
        //}

        public iVariable GetVariable(string name)
        {
            return GetVariable(name, "User");
        }

        public iVariable GetVariable(string name, string nameSpace)
        {
            return _variables[string.Format("{0}{1}", name, nameSpace)];
        }

        private static string GetTaskTypeString(ThisTaskType taskType)
        {
            string ret = string.Format("STOCK:{0}", taskType.ToString());
    
            return ret;
        }

        public void SetExpression(string propertyName, string expression)
        {
            dynamic me = Executable;
            me.SetExpression(propertyName, expression);
        }

        public void SetExpression(string propertyName, iVariable variable)
        {
            dynamic me = Executable;
            me.SetExpression(propertyName, variable.ToString());
        }

        public void SetComponentProperty<T>(string property, T value)
        {
            Type t = GetType();
            PropertyInfo p = t.GetProperty(property);
            if (p == null)
                throw new ArgumentOutOfRangeException(property);

            p.SetValue(this, value);
        }

        public bool FailPackageOnFailure
        {
            get {
                EventsProvider container = _executable as EventsProvider;
                return container.FailPackageOnFailure;
            }
            set
            {
                EventsProvider container = _executable as EventsProvider;
                container.FailPackageOnFailure = value;
            }
        }

        public bool FailParentOnFailure
        {
            get
            {
                EventsProvider container = _executable as EventsProvider;
                return container.FailParentOnFailure;
            }
            set
            {
                EventsProvider container = _executable as EventsProvider;
                container.FailParentOnFailure = value;
            }
        }
    }
}
