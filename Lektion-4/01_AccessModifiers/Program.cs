/*  
    Access Modifiers (Encapsulation) 
    -----------------------------------------------------------------------------------
    Ska kunna:

        public              accessbart överallt, i alla projekt, mellan klasser, relationer etc.
        internal            accessbar inom det egna proektet, mellan klasser i ett projekt
        private             bara accessbart inom det egna kodblocket { }
        protected           accessbart via arv


    Bra att veta/special fall:

        protected internal  accesbar via arb och inom det egna projektet
        private protected   accessbar vi arv och inom det egna kodblocket { }
 


    En klass kan bara vara public eller internal, det bara är så....
*/


using _01_AccessModifiers.Shared.Helpers;

var accessModifier = new AccessModifierHelper();

accessModifier.PublicMethod();
accessModifier.InternalMethod();
accessModifier.ProtectedMethod();
accessModifier.PrivateMethod();