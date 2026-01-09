int nilai;
string nama;

Console.WriteLine("Nilai Siswa App");

Console.WriteLine("Nama Siswa: ");

nama = Console.ReadLine();

Console.WriteLine("Nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai > -75)
{
    Console.WriteLine("Selamat, lulus");
}
else
{
    Console.WriteLine("Maaf, belum lulus!");
}