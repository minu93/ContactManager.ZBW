using ContactManager.Application.Abstractions;

namespace ContactManager.WinForms.UI.Shared.Forms
{
    public partial class ContactHistoryForm : Form
    {
        private readonly Guid _personId;
        private readonly IContactHistoryRepository? _contactHistoryRepo;

        public ContactHistoryForm(Guid personId, string caption, IContactHistoryRepository contactHistoryRepo)
        {
            InitializeComponent();
            _personId = personId;
            _contactHistoryRepo = contactHistoryRepo;
            Text = $"Historie – {caption}";
        }
        protected override async void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            lvHistory.View = View.Details;
            lvHistory.FullRowSelect = true;
            lvHistory.Columns.Clear();
            lvHistory.Columns.Add("Zeit", 140);
            lvHistory.Columns.Add("Aktion", 90);
            lvHistory.Columns.Add("Details", 500);

            await ReloadAsync();
        }
        private async Task ReloadAsync()
        {
            var items = await _contactHistoryRepo!.GetByPersonAsync(_personId);

            lvHistory.BeginUpdate();
            lvHistory.Items.Clear();
            foreach (var h in items)
            {
                var it = new ListViewItem(h.OccurredAt.ToLocalTime().ToString("g"));
                it.SubItems.Add(h.Action.ToString());
                it.SubItems.Add(h.Summary ?? "");
                it.Tag = h;
                lvHistory.Items.Add(it);
            }
            lvHistory.EndUpdate();
        }
    }
}
