using System;
using UnityEngine;

[Serializable]
public class User
{
    private String _userName;
    private String _userSurname;
    private String _userTckn;
    [SerializeField]private String _userAvatarName;
    private UInt16 _userAge;
    private UInt16[] _planStartDate = new UInt16[] {0, 0, 0};
    private UInt16[] _planEndDate = new UInt16[] {0, 0, 0};
    [SerializeField]
    private UInt64 _userAhePoint;
    [SerializeField]
    private String _lastLogin;

    [SerializeField] private bool firstLogin;
    public User(String userName, String userSurname, String userTckn, UInt16 userAge)
    {
        _userName = userName;
        _userSurname = userSurname;
        _userTckn = userTckn;
        _userAge = userAge;
    }

    public void SetPlan(UInt16[] planStartDate, UInt16[] planEndDate)
    {
        planStartDate.CopyTo(_planStartDate,0);
        
        planEndDate.CopyTo(_planEndDate,0);
    }

    public string UserName => _userName;

    public string UserSurname => _userSurname;

    public string UserTckn => _userTckn;

    public string UserAvatarName => _userAvatarName;
    
    public ushort UserAge => _userAge;

    public ushort[] PlanStartDate => _planStartDate;

    public ushort[] PlanEndDate => _planEndDate;

    public bool FirstLogin => firstLogin;

        public void SetUserAvatarName(String name)
    {
        _userAvatarName = name;
    }
}
