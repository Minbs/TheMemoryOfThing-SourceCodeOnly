using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QuestionData
{
	public string guest;
	public int set;
	public int index;
	public string expression;
	public string Data;

	public QuestionData() { }

	QuestionData(string _guest, int _set, int _index, string _expression)
	{
		guest = _guest;
		set = _set;
		index = _index;
		expression = _expression;
	}

	/// <summary>
	/// ������ ������ ���ٸ� true ��ȯ
	/// </summary>
	public static bool operator == (QuestionData left, QuestionData right)
	{
		if (left.guest == right.guest
			&& left.set == right.set
			&& left.index == right.index
			&& left.expression == right.expression)
			return true;

		return false;
	}

	/// <summary>
	/// ������ ������ �ٸ��ٸ� true ��ȯ
	/// </summary>
	public static bool operator !=(QuestionData left, QuestionData right)
	{
		if (left.guest != right.guest
			|| left.set != right.set
			|| left.index != right.index
			|| left.expression != right.expression)
			return true;

		return false;
	}

	/// <summary>
	/// �����
	/// </summary>
	public override string ToString()
	{
		return "�մ� �̸� : " + guest.ToString() + "\n" + "��Ʈ ��ȣ : " + set.ToString() + "\n" + "�ε��� ���� : " + index.ToString() + "\n" + "������ : " + Data.ToString();
	}
}
