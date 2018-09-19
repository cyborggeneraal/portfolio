namespace Test2
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Set (qubit : Qubit, expectedResult : Result) : ()
    {
        body
        {
            let result = M(qubit);

            if (result != expectedResult) {
                X(qubit);
            }
        }
    }

    operation Add () : (Result)    
    {    
        body    
        {    
            mutable result = Zero;

            using(qubits = Qubit[1]) {

                let qubit = qubits[0];

                Set(qubit, Zero);

                H(qubit);

                set result = M(qubit);

            }

            return result;
        }           
    }
}
