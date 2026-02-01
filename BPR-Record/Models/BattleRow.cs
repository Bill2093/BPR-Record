namespace BPR_Record.Models;

public class BattleRow
{
    public int PlayerPower { get; set; }
    public int MonsterPower { get; set; }
    public string MonsterName { get; set; } = "";

    public int Difference => PlayerPower - MonsterPower;
    public string Result => Difference >= 0 ? "Avanza" : "No Avanza";
    public string Icon => Difference >= 0 ? "✔" : "✖";
}
