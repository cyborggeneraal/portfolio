#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Test2", "Set (qubit : Qubit, expectedResult : Result) : ()", new string[] { }, "D:\\Q#\\Pws\\Test2\\Operation.qs", 165L, 7L, 5L)]
[assembly: OperationDeclaration("Test2", "Add () : Result", new string[] { }, "D:\\Q#\\Pws\\Test2\\Operation.qs", 379L, 19L, 5L)]
#line hidden
namespace Test2
{
    public class Set : Operation<(Qubit,Result), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Result)>, IApplyData
        {
            public In((Qubit,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Test2.Set";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Qubit,Result), QVoid> Body => (__in) =>
        {
            var (qubit,expectedResult) = __in;
#line 10 "D:\\Q#\\Pws\\Test2\\Operation.qs"
            var result = M.Apply(qubit);
#line 12 "D:\\Q#\\Pws\\Test2\\Operation.qs"
            if ((result != expectedResult))
            {
#line 13 "D:\\Q#\\Pws\\Test2\\Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Qubit,Result) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit qubit, Result expectedResult)
        {
            return __m__.Run<Set, (Qubit,Result), QVoid>((qubit, expectedResult));
        }
    }

    public class Add : Operation<QVoid, Result>, ICallable
    {
        public Add(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Add";
        String ICallable.FullName => "Test2.Add";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Qubit,Result), QVoid> Set
        {
            get;
            set;
        }

        public override Func<QVoid, Result> Body => (__in) =>
        {
#line 22 "D:\\Q#\\Pws\\Test2\\Operation.qs"
            var result = Result.Zero;
#line 24 "D:\\Q#\\Pws\\Test2\\Operation.qs"
            var qubits = Allocate.Apply(1L);
#line 26 "D:\\Q#\\Pws\\Test2\\Operation.qs"
            var qubit = qubits[0L];
#line 28 "D:\\Q#\\Pws\\Test2\\Operation.qs"
            Set.Apply((qubit, Result.Zero));
#line 30 "D:\\Q#\\Pws\\Test2\\Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(qubit);
#line 32 "D:\\Q#\\Pws\\Test2\\Operation.qs"
            result = M.Apply(qubit);
#line hidden
            Release.Apply(qubits);
#line 36 "D:\\Q#\\Pws\\Test2\\Operation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Set = this.Factory.Get<ICallable<(Qubit,Result), QVoid>>(typeof(Test2.Set));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<Add, QVoid, Result>(QVoid.Instance);
        }
    }
}