Hash=""
removed=0
added=0
totalCount=0
totalChars=$(git ls-files | xargs cat | wc -l)
echo $totalChars
for commit in $(git rev-list master --pretty='format:%as' | sed -z 's/\n/,/g;s/,$/\n/')
do
    hashAndCommit=`echo ${commit} | sed 's/,commit//g'`
    readarray -d , -t strarr <<<"$hashAndCommit"
    hash=${strarr[0]}
    commitDate=${strarr[1]}
   
    if [ ! Hash" ]; then
        removed=$(git diff --word-diff=porcelain --pretty="%H" $previousHash..$hash | grep -e '^-[^-]' | wc -m)
        added=$(git diff --word-diff=porcelain --pretty="Hash..$hash | grep -e '^+[^+]' | wc -m)
        ((totalChars = totalChars + added - removed))
        echo [$commitDate, $totalChars]
    else
        added=$(git diff --word-diff=porcelain --pretty="Hash..$hash | grep -e '^+[^+]' | wc -m)
    Hash=$hash
done