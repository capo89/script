using System;
using System.Collections.Generic;

namespace ScmGroup.XCam.Scripting;

public class Attributes
{
	private sealed class _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D
	{
		public Attribute _0023_003DzLDWhkEg_003D;

		public _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D()
		{
			_ = 6;
			if (2 == 0)
			{
			}
			base._002Ector();
		}

		internal bool _0023_003Dz_qMzZYOCkKgn(Attribute _0023_003DzdO6rEgA_003D)
		{
			_ = 4;
			if (6 == 0)
			{
			}
			Type type = _0023_003DzdO6rEgA_003D.Value.GetType();
			_ = 0;
			if (7 == 0)
			{
			}
			if (type == _0023_003DzLDWhkEg_003D.Value.GetType())
			{
				_ = 0;
				if (8 == 0)
				{
				}
				if (_0023_003DzdO6rEgA_003D.Index == _0023_003DzLDWhkEg_003D.Index)
				{
					return _0023_003DzdO6rEgA_003D.Value.UPar == _0023_003DzLDWhkEg_003D.Value.UPar;
				}
			}
			return false;
		}
	}

	private List<Attribute> _0023_003DzTqtjbDk_003D;

	private int _0023_003DzpQNMhhLM1EFE;

	public Attribute this[int index]
	{
		get
		{
			_ = -1;
			if (4 == 0)
			{
			}
			List<Attribute> list = _0023_003DzTqtjbDk_003D;
			_ = 3;
			if (5 == 0)
			{
			}
			return list[index];
		}
	}

	public int Count
	{
		get
		{
			_ = 6;
			if (5 == 0)
			{
			}
			return _0023_003DzTqtjbDk_003D.Count;
		}
	}

	public Attributes()
	{
		List<Attribute> list = new List<Attribute>();
		if (3u != 0)
		{
			_0023_003DzTqtjbDk_003D = list;
		}
		if (7u != 0)
		{
			_0023_003DzpQNMhhLM1EFE = -1;
		}
		base._002Ector();
	}

	public void Clear()
	{
		if (2u != 0)
		{
			_0023_003DzpQNMhhLM1EFE = -1;
		}
		_0023_003DzTqtjbDk_003D.Clear();
	}

	public List<Attribute> FindAll(Predicate<Attribute> match)
	{
		_ = 2;
		if (7 == 0)
		{
		}
		List<Attribute> list = _0023_003DzTqtjbDk_003D;
		_ = 0;
		if (6 == 0)
		{
		}
		return list.FindAll(match);
	}

	public void RemoveAll(Predicate<Attribute> match)
	{
		_ = 5;
		if (false)
		{
		}
		List<Attribute> list = _0023_003DzTqtjbDk_003D;
		_ = 6;
		if (1 == 0)
		{
		}
		list.RemoveAll(match);
		if (6u != 0)
		{
		}
	}

	public void Remove(Attribute attribute)
	{
		_ = 3;
		if (7 == 0)
		{
		}
		List<Attribute> list = _0023_003DzTqtjbDk_003D;
		_ = 8;
		if (2 == 0)
		{
		}
		list.Remove(attribute);
		if (2u != 0)
		{
		}
	}

	public void Add(Attribute attribute)
	{
		_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D = new _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D();
		_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2;
		if (6u != 0)
		{
			_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2 = _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D;
		}
		if (2u != 0)
		{
			_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2._0023_003DzLDWhkEg_003D = attribute;
		}
		if (_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2._0023_003DzLDWhkEg_003D.Index <= _0023_003DzpQNMhhLM1EFE)
		{
			_0023_003DzTqtjbDk_003D.RemoveAll(_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2._0023_003Dz_qMzZYOCkKgn);
		}
		else
		{
			int index = _0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2._0023_003DzLDWhkEg_003D.Index;
			if (5u != 0)
			{
				_0023_003DzpQNMhhLM1EFE = index;
			}
		}
		_0023_003DzTqtjbDk_003D.Add(_0023_003Dz9ziFS_0024gQ36ZAklAA7Q_003D_003D2._0023_003DzLDWhkEg_003D);
	}

	public Attribute ElementAt(int i)
	{
		Attribute attribute = new Attribute();
		Attribute result;
		if (true)
		{
			result = attribute;
		}
		if (_0023_003DzTqtjbDk_003D != null && i >= 0 && i < _0023_003DzTqtjbDk_003D.Count)
		{
			Attribute attribute2 = _0023_003DzTqtjbDk_003D[i];
			if (5u != 0)
			{
				result = attribute2;
			}
		}
		return result;
	}
}
