using System.ComponentModel;
using BPR_Record.Models;

namespace BPR_Record;

public partial class Form1 : Form
{
    private readonly List<Monster> _monsters;
    private readonly BindingList<BattleRow> _rows = new();

    public Form1()
    {
        InitializeComponent();

        _monsters = BuildMonsters();

        // Bind del grid
        dgvBattles.AutoGenerateColumns = true;
        dgvBattles.DataSource = _rows;

        // Evento: cuando cambie el puntaje, recalcular
        nudPlayerPower.ValueChanged += (_, __) => Recalculate();

        // Evento para colorear filas como Excel
        dgvBattles.CellFormatting += DgvBattles_CellFormatting;

        // Primera carga
        Recalculate();
    }

    private void Recalculate()
    {
        int playerPower = (int)nudPlayerPower.Value;

        _rows.Clear();
        foreach (var m in _monsters)
        {
            _rows.Add(new BattleRow
            {
                PlayerPower = playerPower,
                MonsterPower = m.IllusionStrength,
                MonsterName = m.Name
            });
        }

        // Orden opcional (fuerza ascendente)
        var sorted = _rows.OrderBy(r => r.MonsterPower).ToList();
        _rows.Clear();
        foreach (var r in sorted) _rows.Add(r);

        // Renombrar headers (opcional)
        if (dgvBattles.Columns.Count > 0)
        {
            dgvBattles.Columns[nameof(BattleRow.PlayerPower)].HeaderText = "Jugador";
            dgvBattles.Columns[nameof(BattleRow.MonsterPower)].HeaderText = "Illusion Strength";
            dgvBattles.Columns[nameof(BattleRow.MonsterName)].HeaderText = "Monster";
            dgvBattles.Columns[nameof(BattleRow.Difference)].HeaderText = "Diferencia";
            dgvBattles.Columns[nameof(BattleRow.Result)].HeaderText = "Resultado";
            dgvBattles.Columns[nameof(BattleRow.Icon)].HeaderText = "";
            dgvBattles.Columns[nameof(BattleRow.Icon)].Width = 40;
        }
    }

    private void DgvBattles_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0) return;

        if (dgvBattles.Rows[e.RowIndex].DataBoundItem is not BattleRow row)
            return;

        // Colorear fila: Avanza = verde, No Avanza = rojo suave
        dgvBattles.Rows[e.RowIndex].DefaultCellStyle.BackColor =
            row.Difference >= 0 ? Color.LightGreen : Color.MistyRose;

        // Opcional: centrar icono
        if (dgvBattles.Columns[e.ColumnIndex].Name == nameof(BattleRow.Icon))
        {
            dgvBattles.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }
    }

    private static List<Monster> BuildMonsters()
    {
        return new List<Monster>
        {
            new() { IllusionStrength = 220, Name = "Frost Lizard" },
            new() { IllusionStrength = 400, Name = "Magma Lizard" },
            new() { IllusionStrength = 420, Name = "Gale Lizard" },
            new() { IllusionStrength = 680, Name = "Lightning Lizard" },
            new() { IllusionStrength = 880, Name = "Goblin Warrior" },
            new() { IllusionStrength = 930, Name = "Goblin Axeman" },
            new() { IllusionStrength = 960, Name = "Gablin Priest" },
            new() { IllusionStrength = 1020, Name = "Goblin Guard" },
            new() { IllusionStrength = 1190, Name = "Cabbage Killer" },
            new() { IllusionStrength = 1310, Name = "Cabbage Tough Guy" },
            new() { IllusionStrength = 1340, Name = "Cabbage Blaster" },
            new() { IllusionStrength = 1440, Name = "Blackstone Legion Maskman" },
            new() { IllusionStrength = 1460, Name = "Blackstone Legion Guard" },
            new() { IllusionStrength = 1490, Name = "Blackstone Legion Warrior" },
            new() { IllusionStrength = 1500, Name = "Blackstone Legion Assaulter" },
            new() { IllusionStrength = 1520, Name = "Foxen" },
            new() { IllusionStrength = 1630, Name = "Wasteland Foxen" },
            new() { IllusionStrength = 1930, Name = "Netherworld Caprahorn" },
            new() { IllusionStrength = 2030, Name = "Glimmer Caprahorn" },
            new() { IllusionStrength = 710, Name = "Bluespine Lizard" },
            new() { IllusionStrength = 1030, Name = "Goblin Trickster" },
            new() { IllusionStrength = 1030, Name = "Goblin Shaman" },
            new() { IllusionStrength = 1360, Name = "Gloomy Cabbage" },
            new() { IllusionStrength = 1390, Name = "Ruthless Cabbage" },
            new() { IllusionStrength = 1500, Name = "Blackstone Commander" },
            new() { IllusionStrength = 1500, Name = "Blackstone Vanguard" },
            new() { IllusionStrength = 1730, Name = "Blackfire Foxen" },
            new() { IllusionStrength = 2130, Name = "Emerald Caprahorn" },
            new() { IllusionStrength = 720, Name = "Basilik" },
            new() { IllusionStrength = 1040, Name = "Gablin Chief" },
            new() { IllusionStrength = 1410, Name = "Cabbage Kingpin" },
            new() { IllusionStrength = 1510, Name = "Blackstone Captain" },
            new() { IllusionStrength = 1830, Name = "Crimson Foxen" },
            new() { IllusionStrength = 2230, Name = "Flamehorn" },
        };
    }
}
