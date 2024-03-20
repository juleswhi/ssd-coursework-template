global using FormSystem;
global using static FormSystem.FormManager;

global using State = System.Collections.Generic.Dictionary<System.Collections.Generic.IEnumerable<StateSystem.StateType>, object?>;
global using StateSystem;
global using static StateSystem.StateType;
global using static StateSystem.StateHelper;

global using Password = (string Hashed, byte[] Salt);
global using UserSystem;