#!/usr/bin/env wolframscript
(* ::Package:: *)

(* ::Input:: *)
(*input="kh-tc*)
(*qp-kh*)
(*de-cg*)
(*ka-co*)
(*yn-aq*)
(*qp-ub*)
(*cg-tb*)
(*vc-aq*)
(*tb-ka*)
(*wh-tc*)
(*yn-cg*)
(*kh-ub*)
(*ta-co*)
(*de-co*)
(*tc-td*)
(*tb-wq*)
(*wh-td*)
(*ta-ka*)
(*td-qp*)
(*aq-cg*)
(*wq-ub*)
(*ub-vc*)
(*de-ta*)
(*wq-aq*)
(*wq-vc*)
(*wh-yn*)
(*ka-de*)
(*kh-ta*)
(*co-tc*)
(*wh-qp*)
(*tb-vc*)
(*td-yn";*)


(* ::Input:: *)
(*graph=Graph[UndirectedEdge@@StringSplit[#,"-"]&/@StringSplit[input,"\n"],VertexLabels->"Name"]*)


(* ::Input:: *)
(*subgraphs[l_List]:=If[Length@First@l==3,l,*)
(*DeleteDuplicates[Flatten[Subsets[#,{3}]&/@l,1]]*)
(*]*)


(* ::Text:: *)
(*Part 1*)


(* ::Input:: *)
(*Select[Flatten[subgraphs/@GatherBy[FindClique[graph,{3,Infinity},All],Length],1],MemberQ[#,_String?(StringStartsQ[#,"t"]&)]&]//Length*)


(* ::Text:: *)
(*Part 2*)


(* ::Input:: *)
(*Riffle[Sort@First@FindClique[graph],","]//StringJoin*)
