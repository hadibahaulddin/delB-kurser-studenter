Course matte = new Course("Matematik", 2);
Course fysik = new Course("Fysik", 5);

Student alice = new Student("Alice");
Student bob = new Student("Bob");
Student carl = new Student("Carl");

matte.Enroll(alice);
bob.Join(matte);
fysik.Enroll(alice);
carl.Join(fysik);

matte.Enroll(alice);

matte.Enroll(carl);

matte.RollCall();
alice.Schedule();

Console.WriteLine();

alice.Leave(matte);
fysik.Remove(carl);

bob.Leave(fysik);

Console.WriteLine("Efter borttagning:");
matte.RollCall();
alice.Schedule();
Console.WriteLine(matte);
Console.WriteLine(fysik);
