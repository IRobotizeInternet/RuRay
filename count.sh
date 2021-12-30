previousCommit=""
removed=0
added=0
for commit in $(git rev-list master)
do

    if [ ! -z "$previousCommit" ]; then
	removed=$(git diff --word-diff=porcelain --pretty="%H" $previousCommit..$commit | grep -e '^-[^-]' | wc -m)
	added=$(git diff --word-diff=porcelain --pretty="%H" $previousCommit..$commit | grep -e '^+[^+]' | wc -m)
	echo $added-$removed
	
    fi

    previousCommit=$commit
done