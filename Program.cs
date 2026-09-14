Course matte = new Course("Matematik", 2);
Course fysik = new Course("Fysik", 5);

Student Hadi = new Student("Hadi");
Student Emilia = new Student("Emilia");
Student Enes = new Student("Enes");

matte.Enroll(Hadi);
Emilia.Join(matte);
fysik.Enroll(Hadi);
Enes.Join(fysik);

// Testa dubblettskydd
matte.Enroll(Hadi);

// Testa kapacitet (matte har bara 2 platser, redan full nu)
matte.Enroll(Enes);

Console.WriteLine("Innan borttagning:");
matte.RollCall();
fysik.RollCall();

Console.WriteLine();
Hadi.Schedule();
Emilia.Schedule();
Enes.Schedule();

Console.WriteLine();

// Testa borttagning
Hadi.Leave(matte);
fysik.Remove(Enes);

// Testa att ta bort någon som inte är med (ska inte krascha)
Emilia.Leave(fysik);

Console.WriteLine("Efter borttagning:");
matte.RollCall();
fysik.RollCall();

Console.WriteLine();
Hadi.Schedule();
Emilia.Schedule();
Enes.Schedule();

Console.WriteLine();
Console.WriteLine(matte);
Console.WriteLine(fysik);