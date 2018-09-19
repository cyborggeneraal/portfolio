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

    operation Add (blackBox : String) : (Result)    
    {    
        body    
        {    
            mutable result = Zero;

            using(qubits = Qubit[2]) {

                Set(qubits[0], Zero);
                Set(qubits[1], One);

                H(qubits[0]);
                H(qubits[1]);

                if blackBox == "Constant 1" {
                    X(qubits[0]);
                } elif blackBox == "Identity" {
                    CNOT(qubits[0], qubits[1]);
                } elif (blackBox == "Negation") {
                    CNOT(qubits[0], qubits[1]);
                    X(qubits[0]);
                }
                
                H(qubits[0]);
                H(qubits[1]);

                set result = M(qubits[0]);

            }

            return result;
        }           
    }
}
