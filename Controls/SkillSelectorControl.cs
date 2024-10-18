using LevelZHelper.Models.Enums;

namespace LevelZHelper.Controls
{
    internal partial class SkillSelectorControl : UserControl
    {
        private Dictionary<Button, Skills> _skillButtonDictionary;
        private Skills _activeSkill = Skills.None;
        private bool _allowSwitching = false;
        private static readonly Color _activeBackColor = Color.FromArgb(192, 192, 192);
        private static readonly Color _inactiveBackColor = Color.Transparent;
        private static readonly Color _activeBorderColor = Color.FromArgb(32, 32, 192);

        internal Skills ActiveSkill 
        { 
            get { return _activeSkill; }
            set
            {
                if (_activeSkill == value) return;

                _activeSkill = value;
                ActiveSkillChanged.Invoke(this, _activeSkill);
            }
        }

        internal SkillSelectorControl()
        {
            InitializeComponent();
        }

        internal delegate void ActiveSkillChangedDelegate(SkillSelectorControl sender, Skills skill);

        internal event ActiveSkillChangedDelegate ActiveSkillChanged;

        internal void SetValue(Skills skill)
        {
            _activeSkill = skill;

            UpdateSkillButtons();
        }

        internal void SetActive(bool value)
        {
            _allowSwitching = value;

            foreach (var button in _skillButtonDictionary.Keys)
            {
                if (_skillButtonDictionary[button] == ActiveSkill) continue;

                button.Enabled = value;
            }
        }

        private void SkillSelectorControl_Load(object sender, EventArgs e)
        {
            _skillButtonDictionary = new Dictionary<Button, Skills>
            {
                { HealthSkillButton, Skills.Health },
                { StrengthSkillButton, Skills.Strength },
                { AgilitySkillButton, Skills.Agility },
                { DefenseSkillButton, Skills.Defense },
                { StaminaSkillButton, Skills.Stamina },
                { LuckSkillButton, Skills.Luck },
                { ArcherySkillButton, Skills.Archery },
                { TradeSkillButton, Skills.Trade },
                { SmithingSkillButton, Skills.Smithing },
                { MiningSkillButton, Skills.Mining },
                { FarmingSkillButton, Skills.Farming },
                { AlchemySkillButton, Skills.Alchemy },
            };

            ActiveSkillChanged += (o, e) => UpdateSkillButtons();
        }

        private void SkillButton_Click(object sender, EventArgs e)
        {
            if (!_allowSwitching) return;

            if (sender is Button skillButton && _skillButtonDictionary != null && _skillButtonDictionary.ContainsKey(skillButton))
            {
                var skillClicked = _skillButtonDictionary[skillButton];

                ActiveSkill = skillClicked == _activeSkill ? Skills.None : skillClicked;
            }
        }

        private void UpdateSkillButtons()
        {
            var activeButtons = _skillButtonDictionary.Keys.Where(b => b.BackColor == _activeBackColor).ToList();
            var buttonToBeActivated = ActiveSkill == Skills.None ? null : _skillButtonDictionary.FirstOrDefault(x => x.Value == ActiveSkill).Key;

            foreach (var button in activeButtons)
            {
                if (button == buttonToBeActivated) continue;

                button.BackColor = _inactiveBackColor;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.BorderColor = Color.Black;
                button.Enabled = _allowSwitching;
            }

            if (buttonToBeActivated == null) return;

            buttonToBeActivated.BackColor = _activeBackColor;
            buttonToBeActivated.FlatAppearance.BorderSize = 2;
            buttonToBeActivated.FlatAppearance.BorderColor = _activeBorderColor;
            buttonToBeActivated.Enabled = true;
        }
    }
}
