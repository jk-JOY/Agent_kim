using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 사실상 대화 1개를 넣지만, 일단은 배열로 선언해 놓았다.. 
/// 나중에 string 단위로 고쳐야한다. 
/// </summary>
public class DialogueParser : MonoBehaviour
{
    public Dialogue[] Parse(string _CSVFileName)
    {
        List<Dialogue> dialogueList = new List<Dialogue>(); //대사 리스트를 생성하고
        TextAsset csvData = Resources.Load<TextAsset>(_CSVFileName); //Unity Resources 폴더 파일안에 있는 csv파일을 가져와 타입을 TextAsset으로 변경 

        string[] data = csvData.text.Split(new char[] { '\n' }); // \n = enter csv에서 다음줄로 넘어가는 Escape문

        for (int i = 1; i < data.Length;)  //데이터에 쪼개서 넣는 작업. 
        {
            string[] row = data[i].Split(new char[] { ',' });
            
            Dialogue dialogue = new Dialogue(); // 대사 리스트 생성

            List<string> contextList = new List<string>();   //리스트로 만들고 그리고 다시 배열로 변경하는 과정 필요. 

            contextList.Add(row[1]);

            Debug.Log(row[1]);
            if (++i < data.Length) //i를 미리 증가시키고 data.length 보다 작다면 ; 
            {
                ;
            }

            dialogue.contexts = contextList.ToArray();
            dialogueList.Add(dialogue);
           
        }

        return dialogueList.ToArray();
    }

}

