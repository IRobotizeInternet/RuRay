previousCommit=""
removed=0
added=0
totalCount=0
for commit in $(git rev-list --reverse master --pretty='format:%as' | sed -z 's/\n/,/g;s/,$/\n/')
do
    hashAndCommit=`echo ${commit} | sed 's/,commit//g'`
    readarray -d , -t strarr <<<"$hashAndCommit"
    hash=${strarr[0]}
    commitDate=${strarr[1]}
    echo hello
    if [ ! -z "$previousCommit" ]; then
        echo $previousCommit-kl
        removed=$(git diff --word-diff=porcelain --pretty="%H" $previousCommit..$hash | grep -e '^-[^-]' | wc -m)
        added=$(git diff --word-diff=porcelain --pretty="%H" $previousCommit..$hash | grep -e '^+[^+]' | wc -m)
        ((totalCount = total + removed - added))
        echo $totalCount
    fi

    previousCommit=$hash
done