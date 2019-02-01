#include <iostream>
#include <algorithm>
#include<map>
using namespace std;
int main(){
    int n,s,v;
    cin>>n;
    map<string,int> m;
    for (int i=0;i<n;++i){
        cin>>s>>v;
    m[s]++;
    m[v]++;
    }map<string,int> :: iterator it;
    for(it=m.begin();it!=end();it++){
        cout<< (*it).first << " " << (*it).second << "\n";
    }
return 0;
}


