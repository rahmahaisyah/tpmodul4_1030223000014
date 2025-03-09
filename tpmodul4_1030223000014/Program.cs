namespace tpmodul4_1030223000014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nama kelurahan: ");
            string kelurahan = Console.ReadLine();
            string kodePos = KodePos.getKodePos(kelurahan);
            Console.WriteLine($"Kode Pos {kelurahan}: {kodePos}");
        }
    }
}
