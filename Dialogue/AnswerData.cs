using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerData
{
	public string guest; // ���ϴ� ���
	public int index;
	public string expression; // ǥ��
	public string Data;

	public AnswerData() { }

	AnswerData(string _speaker, int _index, string _expression)
	{
		guest = _speaker;
		index = _index;
		expression = _expression;
	}

	/// <summary>
	/// ������ ������ ���ٸ� true ��ȯ
	/// </summary>
	public static bool operator ==(AnswerData left, AnswerData right)
	{
		return left.guest == right.guest && 
			left.index == right.index && 
			left.expression == right.expression && 
			left.Data == right.Data;
	}

	/// <summary>
	/// ������ ������ �ٸ��ٸ� true ��ȯ
	/// </summary>
	public static bool operator !=(AnswerData left, AnswerData right)
	{
		return left.guest != right.guest || 
			left.index != right.index || 
			left.expression != right.expression || 
			left.Data != right.Data;
	}

	/// <summary>
	/// �����
	/// </summary>
	public override string ToString()
	{
		return $"���ϴ� ��� : {guest}\n�ε��� ���� : {index}\nǥ�� : {expression}\n������ : {Data}";
	}
}